using ExcelDataReader;
using System.Text;

Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
using (var stream = File.Open("Data/Order.xls", FileMode.Open, FileAccess.Read))
{
    using var reader = ExcelReaderFactory.CreateReader(stream);
    while (reader.Read())
    {
        if (reader.GetValue(3) is not null && reader.GetValue(4) is not null)
        {
            Console.WriteLine($"{reader.GetValue(1)} - {reader.GetValue(2)} - {reader.GetValue(3)} - {reader.GetValue(4)}");

            //https://localhost:7036/api

        }
    }
}