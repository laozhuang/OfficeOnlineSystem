using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;
using DataTransfer;

namespace BLL
{
    public class FileBL
    {
        private Treat_fileQueryHql helperT = new Treat_fileQueryHql();
        private Post_fileQueryHql helperP = new Post_fileQueryHql();

        /// <summary>
        /// 返回所有不通过的file
        /// </summary>
        /// <returns>不通过的file list</returns>
        public IList<Treat_file> GetAllTFileU()
        {
            IList<Treat_file> list = helperT.GetAllTreat_file();
            List<Treat_file> listU = new List<Treat_file>();
            foreach (Treat_file f in list)
            {
                if (f.status == 2)
                    listU.Add(f);
            }
            return listU;
        }

        /// <summary>
        /// 返回所有通过的file
        /// </summary>
        /// <returns>通过的file list</returns>
        public IList<Treat_file> GetAllTFileA()
        {
            IList<Treat_file> list = helperT.GetAllTreat_file();
            List<Treat_file> listA = new List<Treat_file>();
            foreach (Treat_file f in list)
            {
                if (f.status == 1)
                    listA.Add(f);
            }
            return listA;
        }

        /// <summary>
        /// 文件通过审查
        /// </summary>
        /// <param name="pFile"></param>
        public void  filePass(Post_file pFile)
        {
            Treat_file tFile = new Treat_file();
            tFile.title = pFile.title;
            tFile.content = pFile.content;
            tFile.username = pFile.username;
            tFile.status = 1;
            helperP.DeletePost_file(pFile);
            helperT.CreateTreatFile(tFile);
        }

        /// <summary>
        /// 文件不通过审查
        /// </summary>
        /// <param name="pFile"></param>
        public void fileNoPass(Post_file pFile)
        {
            Treat_file tFile = new Treat_file();
            tFile.title = pFile.title;
            tFile.content = pFile.content;
            tFile.username = pFile.username;
            tFile.status = 2;
            helperP.DeletePost_file(pFile);
            helperT.CreateTreatFile(tFile);
 
        }

        /// <summary>
        /// 更新未审查的文件
        /// </summary>
        /// <param name="pFile"></param>
        public void UpdatePFile(Post_file pFile)
        {
            helperP.UpdatePost_file(pFile);
 
        }

        /// <summary>
        /// 取得所有未审批的文件
        /// </summary>
        /// <returns></returns>
        public IList<Post_file> GetAllPFile()
        {
            IList<Post_file> list1 = new List<Post_file>();
            IList<Post_file> list =helperP.GetAllPost_file();
            foreach (Post_file file in list)
            {
                if (file.status == 0)
                {
                    list1.Add(file);
 
                }
            }
            return list1;
        }

        /// <summary>
        /// 取得草稿文件
        /// </summary>
        /// <returns></returns>
        public IList<Post_file> GetAllSemiFile()
        {
            IList<Post_file> list1 = new List<Post_file>();
            IList<Post_file> list = helperP.GetAllPost_file();
            foreach (Post_file file in list)
            {
                if (file.status == -1)
                {
                    list1.Add(file);
                }
            }
            return list1;
        }

        public Treat_file GetTFileById(int id)
        {
            return  helperT.GetTreat_fileByID(id);
 
        }

        public Post_file GetPFileById(int id)
        {
            return helperP.GetPost_fileById(id);

        }

        public void DeleteTFileById(int id)
        {
           Treat_file tFile= GetTFileById(id);
           helperT.DeleteTreat_file(tFile);
 
        }


        /// <summary>
        /// 更新草稿
        /// </summary>
        /// <param name="file"></param>
        public void UpdateSemiFile(Post_file file)
        {
            if (file.id == 0)
            {
                CreateSemiFile(file);
            }
            else
            {
                file.status = -1;
                helperP.UpdatePost_file(file);
            }
        }

        /// <summary>
        /// 创建草稿
        /// </summary>
        /// <param name="file"></param>
        public void CreateSemiFile(Post_file file)
        {
            file.status = -1;
            helperP.CreatePostFile(file);

        }
        /// <summary>
        /// 把草稿发表为文件
        /// </summary>
        /// <param name="file"></param>
        public void PostSemiFile(Post_file file)
        {
            file.status = 0;
            helperP.CreatePostFile(file);
        }

        /// <summary>
        /// 通过用户名获得未审批的文件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IList<Post_file> GetPFileByName(string name)
        {
            IList<Post_file> l1 = new List<Post_file>();
            IList<Post_file> list = helperP.GetAllPost_file();
            foreach (Post_file f in list)
            {
                if (f.username == name && f.status == 0)
                {
                    l1.Add(f);
                }
            }
            return l1;

        }

        /// <summary>
        /// 通过用户名获得已审批的文件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IList<Treat_file> GetTFileByName(string name)
        {
            IList<Treat_file> l1 = new List<Treat_file>();
            IList<Treat_file> list = helperT.GetAllTreat_file();
            foreach (Treat_file f in list)
            {
                if (f.username == name)
                {
                    l1.Add(f);
                }
            }
            return l1;

        }

        /// <summary>
        /// 通过用户名获得草稿文件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public IList<Post_file> GetSemiFileByName(string name)
        {
            IList<Post_file> l1 = new List<Post_file>();
            IList<Post_file> list = helperP.GetAllPost_file();
            foreach (Post_file f in list)
            {
                if (f.username == name && f.status == -1)
                {
                    l1.Add(f);
                }
            }
            return l1;

        }

    }
}
