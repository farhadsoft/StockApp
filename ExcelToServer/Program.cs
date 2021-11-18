using ExcelDataReader;
using System.Configuration;
using System.Text;
using System.Text.Json;

List<Product> Products = new();

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
using (var stream = File.Open("Data/Order.xls", FileMode.Open, FileAccess.Read))
{
    using var reader = ExcelReaderFactory.CreateReader(stream);
    while (reader.Read())
    {
        if (reader.GetValue(3) is not null && reader.GetValue(4) is not null && reader.Depth > 3)
        {
            Products.Add(new Product
            (
                reader.GetValue(1).ToString(),
                reader.GetValue(2).ToString(),
                reader.GetValue(3).ToString(),
                int.Parse(reader.GetValue(4).ToString())
            ));
        }
    }
    await SendToApi(Products);
}

static async Task SendToApi(List<Product> products)
{
    var json = JsonSerializer.Serialize(products);
    var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

    using var httpClient = new HttpClient();
    var httpResponse = await httpClient.PostAsync(ConfigurationManager.AppSettings["azure"], httpContent);
    if (httpResponse.Content is not null)
    {
        var responseContent = await httpResponse.Content.ReadAsStringAsync();
    }
}