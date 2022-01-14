using Microsoft.AspNetCore.Mvc;

/// <summary>
/// Save all process to logging file
/// </summary>
public class LoggerCls : ControllerBase
{
    string _Path = @"C:\Users\happy\source\repos\bootcampHomeworks\Log\";
    string _FileName = DateTime.Now.ToString("yyyyMMdd") + ".txt";

    public void CreateLog(string message)
    {
        FileStream fs = new FileStream(_Path + _FileName, FileMode.Append, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine(DateTime.Now.ToString() + ": "+ message);
        sw.Flush();
        sw.Close();
        fs.Close();
    }
}
