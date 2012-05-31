using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using DataTransfer;

namespace DataAccessLayer
{
    public class Treat_fileQueryHql :NHibernateDataProviderHelper
    {
        protected ISession _session { get; set; }

        public Treat_fileQueryHql()
        {


            _session = this.GetSession(); ;
        }


        public void CreateTreatFile(Treat_file treatfile)
        {
            _session.Save(treatfile);
            _session.Flush();
        }


        public IList<Treat_file> GetAllPost_file()
        {
            //返回所有User类的实例
            return _session.CreateQuery("from Treat_file").List<Treat_file>();
        }

        public bool IsTFileExist(int id)
        {
            IList<Treat_file> list = _session.CreateQuery("from Treat_file f where f.id=:fid").SetInt32("fid", id).List<Treat_file>();
            if (list.Count != 0)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        public Treat_file GetTreat_fileByID(int id)
        {
            IList<Treat_file> list = _session.CreateQuery("from Treat_file f where f.id=:fid").SetInt32("fid", id).List<Treat_file>();
            if (list.Count != 0)
            {
                return list[0];
            }
            else
            {
                return null;
            }
        }

        public void DeleteTreat_file(Treat_file file)
        {
            _session.Delete(file);
            _session.Flush();
        }

        public void UpdateTreat_file(Treat_file file)
        {
            _session.Update(file);
            _session.Flush();
        }
    }
}
