string[] files = Directory.GetFiles("Testfolder");
double sum = 0;

foreach (string file in files)
{
    FileInfo fileInfo = new FileInfo(file);
    sum += fileInfo.Length;
}
sum = sum / 1024 / 1024;
Console.WriteLine(sum);
