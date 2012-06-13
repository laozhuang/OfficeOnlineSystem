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
    }
}
