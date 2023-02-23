string path = "C:/Users/Algor/Desktop/ГикБрайнс/1 четверть/Знакомство с языками программирования/Examples/les7.1-lookFileInDir";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CretionTime);
// FilInfo[] fi = di.GetFiles();

// for(int i = 0; i < fi.Length; i++)
// {
//   System.Console.WriteLine(fi[i].Name);
// }