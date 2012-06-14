using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using DataTransfer;

namespace DataAccessLayer
{
    public class Post_fileQueryHql:NHibernateDataProviderHelper
    {
        protected ISession _session { get; set; }

        public Post_fileQueryHql()
        {
            _session =this.GetSession();
        }

        public void CreatePostFile(Post_file postfile)
        {
            _session.Save(postfile);
            _session.Flush();
        }

        public IList<Post_file> GetAllPost_file()
        {
            //返回所有User类的实例
            return _session.CreateQuery("from Post_file").List<Post_file>();
        }

        public Post_file GetPost_fileById(int id)
        {
            IList<Post_file> list = _session.CreateQuery("from Post_file f where f.id=:fID").SetInt32("fID", id).List<Post_file>();
            if (list.Count != 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }
        public bool IsPFileExits(int id)
        {

           IList<Post_file> list =  _session.CreateQuery("from Post_file f where f.id=:fid").SetInt32("fid", id).List<Post_file>();
           if (list.Count != 0)
           {
               return true;
           }
           else
           {
               return false;
           }
        }

        public void DeletePost_file(Post_file file)
        {
            _session.Delete(file);
            _session.Flush();
        }

        public void UpdatePost_file(Post_file file)
        {
            _session.Update(file);
            _session.Flush();
        }
       
    }
}
