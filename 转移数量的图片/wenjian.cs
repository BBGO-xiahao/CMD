using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace 转移数量的图片
{
    class wenjian
    {
        public void copy1(string sourepath, string despath, string pattern, int quantity)
        {
            string wenjianming1 = Path.GetFileName(sourepath);//获取主文件名
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);//形成新的路径
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }
                DirectoryInfo zizi1 = new DirectoryInfo(sourepath);//大文件夹

                FileInfo[] files = zizi1.GetFiles();
                List<FileInfo> filem = new List<FileInfo>();

                foreach (FileInfo filem1 in files)
                {
                    if (pattern == "all")
                    {
                        filem.Add(filem1);
                        continue;
                    }
                    if (filem1.Extension == pattern)
                    {
                        filem.Add(filem1);
                    }
                }
                if (filem.Count < quantity)
                {
                    for (int x = 0; x < filem.Count; x++)
                    {
                        FileInfo file = filem[x];
                        if (pattern == "all")
                        {
                            file.CopyTo(Path.Combine(wenjianlujingmove, file.Name));//复制 ，剪切的话file.MoveTo();
                            continue;
                        }
                        if (file.Extension == pattern)
                        {
                            file.CopyTo(Path.Combine(wenjianlujingmove, file.Name));//复制 ，剪切的话file.MoveTo();
                        }
                    }
                }
                else
                {
                    if (filem.Count >= quantity)
                    {
                        for (int x = 0; x < quantity; x++)
                        {
                            FileInfo file = filem[x];
                            if (pattern == "all")
                            {
                                file.CopyTo(Path.Combine(wenjianlujingmove, file.Name)); //复制 ，剪切的话file.MoveTo();
                                continue;
                            }
                            if (file.Extension == pattern)
                            {
                                file.CopyTo(Path.Combine(wenjianlujingmove, file.Name)); //复制 ，剪切的话file.MoveTo();
                            }
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void copy2(string sourepath, string despath, string pattern, int quantity)
        {
            string wenjianming1 = Path.GetFileName(sourepath);
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }

                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名

                List<string> ziwenjanlujing2 = new List<string>();//子子文件夹的完整路径
                foreach (DirectoryInfo ziwen in dii)//子子文件夹的完整路径
                {
                    ziwenjanlujing2.Add(ziwen.FullName.ToString());

                }



                for (int i = 0; i < dii.Length; i++)
                {
                    string ziwenjianlujing = Path.Combine(wenjianlujingmove, dii[i].ToString());
                    if (Directory.Exists(ziwenjianlujing) == false)
                    {
                        Directory.CreateDirectory(ziwenjianlujing);
                    }
                    else
                    {
                        Directory.Delete(ziwenjianlujing, true);
                        Directory.CreateDirectory(ziwenjianlujing);//子文件名
                    }
                    DirectoryInfo zizi2 = new DirectoryInfo(ziwenjanlujing2[i]);//大文件夹

                    FileInfo[] files = zizi2.GetFiles();

                    List<FileInfo> filem = new List<FileInfo>();

                    foreach (FileInfo filem1 in files)
                    {
                        if (pattern == "all")
                        {
                            filem.Add(filem1);
                            continue;
                        }
                        if (filem1.Extension == pattern)
                        {
                            filem.Add(filem1);
                        }
                    }
                    if (filem.Count < quantity)
                    {
                        for (int x = 0; x < filem.Count; x++)
                        {
                            FileInfo file = filem[x];
                            if (pattern == "all")
                            {
                                file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                continue;
                            }

                            if (file.Extension == pattern)
                            {
                                file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                            }
                        }
                    }
                    else
                    {
                        if (filem.Count >= quantity)
                        {
                            for (int x = 0; x < quantity; x++)
                            {
                                FileInfo file = filem[x];
                                if (pattern == "all")
                                {
                                    file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                    continue;
                                }

                                if (file.Extension == pattern)
                                {
                                    file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                }
                            }
                        }

                    }




                }


            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Copy2(string sourepath, string despath, string pattern, int quantity, string[] arr_str)
        {
            string wenjianming1 = Path.GetFileName(sourepath);
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }

                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名

                List<string> ziwenjanlujing2 = new List<string>();//子子文件夹的完整路径
                List<DirectoryInfo> ziwenjanlujing4 = new List<DirectoryInfo>();//子子文件夹的完整路径
                List<DirectoryInfo> ziwenjanlujing5 = new List<DirectoryInfo>();//过滤过的文件

                foreach (DirectoryInfo ziwen in dii)//子子文件夹的完整路径
                {

                    foreach (string zhidingwenjian in arr_str)
                    {
                        string zhidingwenjian3 = ConvertToEn(Regex.Replace(zhidingwenjian, @"[\r]", ""));
                        string xva = ConvertToEn(Path.GetFileName(ziwen.Name));
                        if (zhidingwenjian3.CompareTo(xva) == 0)
                        {
                            ziwenjanlujing2.Add(ziwen.FullName.ToString());
                            ziwenjanlujing5.Add(ziwen);
                        }
                    }

                }



                for (int i = 0; i < ziwenjanlujing2.Count; i++)
                {
                    string ziwenjianlujing = Path.Combine(wenjianlujingmove, ziwenjanlujing5[i].ToString());
                    if (Directory.Exists(ziwenjianlujing) == false)
                    {
                        Directory.CreateDirectory(ziwenjianlujing);
                    }
                    else
                    {
                        Directory.Delete(ziwenjianlujing, true);
                        Directory.CreateDirectory(ziwenjianlujing);//子文件名
                    }
                    DirectoryInfo zizi2 = new DirectoryInfo(ziwenjanlujing2[i]);//大文件夹

                    FileInfo[] files = zizi2.GetFiles();

                    List<FileInfo> filem = new List<FileInfo>();

                    foreach (FileInfo filem1 in files)
                    {

                        if (pattern == "all")
                        {
                            filem.Add(filem1);
                            continue;
                        }
                        if (filem1.Extension == pattern)
                        {
                            filem.Add(filem1);
                        }
                    }
                    if (filem.Count < quantity)
                    {
                        for (int x = 0; x < filem.Count; x++)
                        {
                            FileInfo file = filem[x];
                            if (pattern == "all")
                            {
                                file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                continue;
                            }
                            if (file.Extension == pattern)
                            {
                                file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                            }
                        }
                    }
                    else
                    {
                        if (filem.Count >= quantity)
                        {
                            for (int x = 0; x < quantity; x++)
                            {
                                FileInfo file = filem[x];
                                if (pattern == "all")
                                {
                                    file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                    continue;
                                }
                                if (file.Extension == pattern)
                                {
                                    file.CopyTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                }
                            }
                        }

                    }

                }
               


            }
            catch (Exception)
            {

                throw;
            }

        }

        public void copy3(string sourepath, string despath, string pattern, int quantity)
        {
            string wenjianming1 = Path.GetFileName(sourepath);
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }

                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名
                for (int i = 0; i < dii.Length; i++)
                {

                    DirectoryInfo[] dii1 = dii[i].GetDirectories();//获取子文件夹名
                    for (int o = 0; o < dii1.Length; o++)
                    {
                        string NameFilePath = Path.Combine(wenjianlujingmove, dii[i].ToString(), dii1[o].ToString());
                        if (Directory.Exists(NameFilePath) == false)
                        {
                            Directory.CreateDirectory(NameFilePath);
                        }
                        else
                        {
                            Directory.Delete(NameFilePath, true);
                            Directory.CreateDirectory(NameFilePath);//子文件名
                        }
                        DirectoryInfo dir3 = new DirectoryInfo(dii1[o].FullName);//大文件夹
                        FileInfo[] files = dir3.GetFiles();


                        for (int z = 0; z < files.Length; z++)
                        {

                            List<FileInfo> filem = new List<FileInfo>();

                            foreach (FileInfo filem1 in files)
                            {
                                if (pattern == "all")
                                {
                                    filem.Add(filem1);
                                    continue;
                                }
                                if (filem1.Extension == pattern)
                                {
                                    filem.Add(filem1);
                                }
                            }
                            if (filem.Count < quantity)
                            {
                                for (int x = 0; x < filem.Count; x++)
                                {

                                    FileInfo file = filem[x];
                                    if (pattern == "all")
                                    {
                                        file.CopyTo(Path.Combine(NameFilePath, file.Name), true); //复制 ，剪切的话file.MoveTo();
                                        continue;
                                    }
                                    if (file.Extension == pattern)
                                    {
                                        file.CopyTo(Path.Combine(NameFilePath, file.Name), true); //复制 ，剪切的话file.MoveTo();
                                    }
                                }
                            }
                            else
                            {
                                if (filem.Count >= quantity)
                                {
                                    for (int x = 0; x < quantity; x++)
                                    {
                                        FileInfo file = files[x];
                                        if (pattern == "all")
                                        {
                                            file.CopyTo(Path.Combine(NameFilePath, file.Name), true); //复制 ，剪切的话file.MoveTo();
                                            continue;
                                        }
                                        if (file.Extension == pattern)
                                        {
                                            file.CopyTo(Path.Combine(NameFilePath, file.Name), true); //复制 ，剪切的话file.MoveTo();
                                        }
                                    }
                                }

                            }

                        }


                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void moveto1(string sourepath, string despath, string pattern, int quantity)
        {
            string wenjianming1 = Path.GetFileName(sourepath);//获取主文件名
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);//形成新的路径
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }
                DirectoryInfo zizi1 = new DirectoryInfo(sourepath);//大文件夹

                FileInfo[] files = zizi1.GetFiles();
                List<FileInfo> filem = new List<FileInfo>();

                foreach (FileInfo filem1 in files)
                {
                    if (pattern == "all")
                    {
                        filem.Add(filem1);
                        continue;
                    }
                    if (filem1.Extension == pattern)
                    {
                        filem.Add(filem1);
                    }
                }
                if (filem.Count < quantity)
                {
                    for (int x = 0; x < filem.Count; x++)
                    {
                        FileInfo file = filem[x];
                        if (pattern == "all")
                        {
                            file.MoveTo(Path.Combine(wenjianlujingmove, file.Name));//复制 ，剪切的话file.MoveTo();
                            continue;
                        }

                        if (file.Extension == pattern)
                        {
                            file.MoveTo(Path.Combine(wenjianlujingmove, file.Name));//复制 ，剪切的话file.MoveTo();
                        }
                    }
                }
                else
                {
                    if (filem.Count >= quantity)
                    {
                        for (int x = 0; x < quantity; x++)
                        {
                            FileInfo file = filem[x];
                            if (pattern == "all")
                            {
                                file.MoveTo(Path.Combine(wenjianlujingmove, file.Name)); //复制 ，剪切的话file.MoveTo();
                                continue;
                            }
                            if (file.Extension == pattern)
                            {
                                file.MoveTo(Path.Combine(wenjianlujingmove, file.Name)); //复制 ，剪切的话file.MoveTo();
                            }
                        }
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        public void moveto2(string sourepath, string despath, string pattern, int quantity)
        {
            string wenjianming1 = Path.GetFileName(sourepath);
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }

                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名

                List<string> ziwenjanlujing2 = new List<string>();//子子文件夹的完整路径
                foreach (DirectoryInfo ziwen in dii)//子子文件夹的完整路径
                {
                    ziwenjanlujing2.Add(ziwen.FullName.ToString());

                }



                for (int i = 0; i < dii.Length; i++)
                {
                    string ziwenjianlujing = Path.Combine(wenjianlujingmove, dii[i].ToString());
                    if (Directory.Exists(ziwenjianlujing) == false)
                    {
                        Directory.CreateDirectory(ziwenjianlujing);
                    }
                    else
                    {
                        Directory.Delete(ziwenjianlujing, true);
                        Directory.CreateDirectory(ziwenjianlujing);//子文件名
                    }
                    DirectoryInfo zizi2 = new DirectoryInfo(ziwenjanlujing2[i]);//大文件夹

                    FileInfo[] files = zizi2.GetFiles();

                    List<FileInfo> filem = new List<FileInfo>();

                    foreach (FileInfo filem1 in files)
                    {

                        if (pattern=="all")
                        {
                            filem.Add(filem1);
                            continue;
                        }
                        if (filem1.Extension == pattern)
                        {
                            filem.Add(filem1);
                        }
                    }
                    if (filem.Count < quantity)
                    {
                        for (int x = 0; x < filem.Count; x++)
                        {
                            FileInfo file = filem[x];
                            if (pattern == "all")
                            {
                                file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                continue;
                            }
                            if (file.Extension == pattern)
                            {
                                file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                            }
                        }
                    }
                    else
                    {
                        if (filem.Count >= quantity)
                        {
                            for (int x = 0; x < quantity; x++)
                            {
                                FileInfo file = filem[x];
                                if (pattern=="all")
                                {
                                    file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                    continue;
                                }
                                if (file.Extension == pattern)
                                {
                                    file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                }
                            }
                        }

                    }




                }

                DeleteEmptyFolders(sourepath);


            }
            catch (Exception)
            {

                throw;
            }

        }
       public void DeleteEmptyFolders(string parentFolder)//删除空文件夹
        {
            var dir = new DirectoryInfo(parentFolder);
            var subdirs = dir.GetDirectories("*.*", SearchOption.AllDirectories);

            foreach (var subdir in subdirs)
            {
                if (!Directory.Exists(subdir.FullName)) continue;

                var subFiles = subdir.GetFileSystemInfos("*.*", SearchOption.AllDirectories);

                var findFile = false;
                foreach (var sub in subFiles)
                {
                    findFile = (sub.Attributes & FileAttributes.Directory) == 0;

                    if (findFile) break;
                }

                if (!findFile) subdir.Delete(true);
            }
        }

        public void Moveto2(string sourepath, string despath, string pattern, int quantity, string[] arr_str)
        {
            string wenjianming1 = Path.GetFileName(sourepath);
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }

                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名

                List<string> ziwenjanlujing2 = new List<string>();//子子文件夹的完整路径
                List<DirectoryInfo> ziwenjanlujing4 = new List<DirectoryInfo>();//子子文件夹的完整路径
                List< DirectoryInfo> ziwenjanlujing5 = new List<DirectoryInfo>();//过滤过的文件
                List< DirectoryInfo> ziwenjanlujing6 = new List<DirectoryInfo>();//过滤过的文件

                foreach (DirectoryInfo ziwen in dii)//子子文件夹的完整路径
                {
                   
                    foreach (string zhidingwenjian in arr_str)
                    {
                        string zhidingwenjian3 = ConvertToEn(Regex.Replace(zhidingwenjian, @"[\r]", ""));
                        string wenjianname2 = ConvertToEn(Path.GetFileName(ziwen.Name));
                        if (zhidingwenjian3.CompareTo(wenjianname2) == 0)
                        {
                            ziwenjanlujing2.Add(ziwen.FullName.ToString());
                            ziwenjanlujing5.Add(ziwen);
                        }
                    }
                   
                }



                for (int i = 0; i < ziwenjanlujing2.Count; i++)
                {
                    string ziwenjianlujing = Path.Combine(wenjianlujingmove, ziwenjanlujing5[i].ToString());
                    if (Directory.Exists(ziwenjianlujing) == false)
                    {
                        Directory.CreateDirectory(ziwenjianlujing);
                    }
                    else
                    {
                        Directory.Delete(ziwenjianlujing, true);
                        Directory.CreateDirectory(ziwenjianlujing);//子文件名
                    }
                    DirectoryInfo zizi2 = new DirectoryInfo(ziwenjanlujing2[i]);//大文件夹

                    FileInfo[] files = zizi2.GetFiles();

                    List<FileInfo> filem = new List<FileInfo>();

                    foreach (FileInfo filem1 in files)
                    {

                        if (pattern == "all")
                        {
                            filem.Add(filem1);
                            continue;
                        }
                        if (filem1.Extension == pattern)
                        {
                            filem.Add(filem1);
                        }
                    }
                    if (filem.Count < quantity)
                    {
                        for (int x = 0; x < filem.Count; x++)
                        {
                            FileInfo file = filem[x];
                            if (pattern == "all")
                            {
                                file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                continue;
                            }
                            if (file.Extension == pattern)
                            {
                                file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                            }
                        }
                    }
                    else
                    {
                        if (filem.Count >= quantity)
                        {
                            for (int x = 0; x < quantity; x++)
                            {
                                FileInfo file = filem[x];
                                if (pattern == "all")
                                {
                                    file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                    continue;
                                }
                                if (file.Extension == pattern)
                                {
                                    file.MoveTo(Path.Combine(ziwenjianlujing, file.Name)); //复制 ，剪切的话file.MoveTo();
                                }
                            }
                        }

                    }

                }
                DeleteEmptyFolders(sourepath);



            }
            catch (Exception)
            {

                throw;
            }

        }

        public void moveto3(string sourepath, string despath, string pattern, int quantity)
        {
            string wenjianming1 = Path.GetFileName(sourepath);
            string wenjianlujingmove = Path.Combine(despath, wenjianming1);
            try
            {


                if (Directory.Exists(wenjianlujingmove) == false)
                {
                    Directory.CreateDirectory(wenjianlujingmove);//创建文件夹
                }
                else
                {
                    Directory.Delete(wenjianlujingmove, true);
                    Directory.CreateDirectory(wenjianlujingmove);//子文件名
                }

                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名
                for (int i = 0; i < dii.Length; i++)
                {

                    DirectoryInfo[] dii1 = dii[i].GetDirectories();//获取子文件夹名
                    for (int o = 0; o < dii1.Length; o++)
                    {
                        string NameFilePath = Path.Combine(wenjianlujingmove, dii[i].ToString(), dii1[o].ToString());
                        if (Directory.Exists(NameFilePath) == false)
                        {
                            Directory.CreateDirectory(NameFilePath);
                        }
                        else
                        {
                            Directory.Delete(NameFilePath, true);
                            Directory.CreateDirectory(NameFilePath);//子文件名
                        }
                        DirectoryInfo dir3 = new DirectoryInfo(dii1[o].FullName);//大文件夹
                        FileInfo[] files = dir3.GetFiles();


                        for (int z = 0; z < files.Length; z++)
                        {

                            List<FileInfo> filem = new List<FileInfo>();

                            foreach (FileInfo filem1 in files)
                            {
                                if (pattern == "all")
                                {
                                    filem.Add(filem1);
                                    continue;
                                }
                                if (filem1.Extension == pattern)
                                {
                                    filem.Add(filem1);
                                }
                            }
                            if (filem.Count < quantity)
                            {
                                for (int x = 0; x < filem.Count; x++)
                                {
                                    FileInfo file = filem[x];
                                    if (pattern == "all")
                                    {
                                        file.MoveTo(Path.Combine(NameFilePath, file.Name)); //复制 ，剪切的话file.MoveTo();
                                        continue;
                                    }

                                    if (file.Extension == pattern)
                                    {
                                        file.MoveTo(Path.Combine(NameFilePath, file.Name)); //复制 ，剪切的话file.MoveTo();
                                    }
                                }
                            }
                            else
                            {
                                if (filem.Count >= quantity)
                                {
                                    for (int x = 0; x < quantity; x++)
                                    {
                                        FileInfo file = files[x];
                                        if (pattern == "all")
                                        {
                                            file.MoveTo(Path.Combine(NameFilePath, file.Name)); //复制 ，剪切的话file.MoveTo();
                                            continue;
                                        }
                                        if (file.Extension == pattern)
                                        {
                                            file.MoveTo(Path.Combine(NameFilePath, file.Name)); //复制 ，剪切的话file.MoveTo();
                                        }
                                    }
                                }

                            }

                        }


                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void del1(string sourepath, string pattern)
        {

            try
            {
                DirectoryInfo zizi1 = new DirectoryInfo(sourepath);//大文件夹

                FileInfo[] files = zizi1.GetFiles();
                List<FileInfo> filem = new List<FileInfo>();

                foreach (FileInfo filem1 in files)
                {
                    if (pattern == "all")
                    {
                        filem.Add(filem1);
                        continue;
                    }
                    if (filem1.Extension == pattern)
                    {
                        filem.Add(filem1);
                    }
                }
                for (int x = 0; x < filem.Count; x++)
                {
                    FileInfo file = filem[x];
                    if (pattern == "all")
                    {
                        file.Delete();
                        continue;
                    }
                    if (file.Extension == pattern)
                    {
                        file.Delete();
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
        public void del2(string sourepath, string pattern)
        {

            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名

                List<string> ziwenjanlujing2 = new List<string>();//子子文件夹的完整路径
                foreach (DirectoryInfo ziwen in dii)//子子文件夹的完整路径
                {
                    ziwenjanlujing2.Add(ziwen.FullName.ToString());

                }



                for (int i = 0; i < dii.Length; i++)
                {

                    DirectoryInfo zizi2 = new DirectoryInfo(ziwenjanlujing2[i]);//大文件夹

                    FileInfo[] files = zizi2.GetFiles();

                    List<FileInfo> filem = new List<FileInfo>();

                    foreach (FileInfo filem1 in files)
                    {
                        if (pattern == "all")
                        {
                            filem.Add(filem1);
                            continue;
                        }
                        if (filem1.Extension == pattern)
                        {
                            filem.Add(filem1);
                        }
                    }
                    for (int x = 0; x < filem.Count; x++)
                    {
                        FileInfo file = filem[x];
                        if (pattern == "all")
                        {
                            file.Delete();
                            continue;
                        }

                        if (file.Extension == pattern)
                        {
                            file.Delete(); //复制 ，剪切的话file.MoveTo();
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void Del2(string sourepath, string pattern, string[] arr_str)
        {

            try
            {
                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名

                List<string> ziwenjanlujing2 = new List<string>();//子子文件夹的完整路径
                foreach (DirectoryInfo ziwen in dii)//子子文件夹的完整路径
                {
                    foreach (string zhidingwenjian in arr_str)
                    {
                        string zhidingwenjian3 = ConvertToEn(Regex.Replace(zhidingwenjian, @"[\r]", ""));
                        string xva = ConvertToEn(Path.GetFileName(ziwen.Name));
                        if (zhidingwenjian3.CompareTo(xva) == 0)
                        {
                            ziwenjanlujing2.Add(ziwen.FullName.ToString());

                        }
                    }

                }
                foreach (string pathdel in ziwenjanlujing2)
                {
                    Directory.Delete(pathdel, true);

                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public void del3(string sourepath,string pattern)
        {
            try
            {


                DirectoryInfo dir = new DirectoryInfo(sourepath);//大文件夹
                DirectoryInfo[] dii = dir.GetDirectories();//获取子文件夹名
                for (int i = 0; i < dii.Length; i++)
                {

                    DirectoryInfo[] dii1 = dii[i].GetDirectories();//获取子文件夹名
                    for (int o = 0; o < dii1.Length; o++)
                    {
                      
                        DirectoryInfo dir3 = new DirectoryInfo(dii1[o].FullName);//大文件夹
                        FileInfo[] files = dir3.GetFiles();


                        for (int z = 0; z < files.Length; z++)
                        {

                            List<FileInfo> filem = new List<FileInfo>();

                            foreach (FileInfo filem1 in files)
                            {
                                if (pattern == "all")
                                {
                                    filem.Add(filem1);
                                    continue;
                                }
                                if (filem1.Extension == pattern)
                                {
                                    filem.Add(filem1);
                                }
                            }
                               for (int x = 0; x < filem.Count; x++)
                                {
                                    FileInfo file = filem[x];
                                if (pattern == "all")
                                {
                                    file.Delete();
                                    continue;
                                }

                                if (file.Extension == pattern)
                                    {
                                        file.Delete(); //复制 ，剪切的话file.MoveTo();
                                    }
                                }
                            

                        }


                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }
        public static string ConvertToEn(string text)//中文变英文字符
        {
            const string ch = "。；，？！、“”‘’（）—";//中文字符
            const string en = @".;,?!\""""''()-";//英文字符
            char[] c = text.ToCharArray();
            for (int i = 0; i < c.Length; i++)
            {
                int n = ch.IndexOf(c[i]);
                if (n != -1) c[i] = en[n];
            }
            return new string(c);
        }


    }
}
