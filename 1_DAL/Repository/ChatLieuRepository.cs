using _1_DAL.DBContext;
using _1_DAL.IRepositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Repository
{
    public class ChatLieuRepository : IChatLieuRepositories
    {
        public ChatLieuRepository() 
        {
            _dbContext = new ApplicationDBContext();
        }
        private ApplicationDBContext _dbContext;

       
        public List<ChatLieu> GetAll()
        {
            return _dbContext.ChatLieus.ToList();
        }


        public bool Them(ChatLieu chatLieu)
        {
            try
            {
                _dbContext.ChatLieus.Add(chatLieu);
                _dbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Sua(ChatLieu chatLieu)
        {
            try
            {
                var CL = _dbContext.ChatLieus.Find(chatLieu.Id);
                if (CL != null)
                {
                    CL.Ma = chatLieu.Ma;
                    CL.Ten = chatLieu.Ten;
                    _dbContext.ChatLieus.Update(CL);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }

        }

        public bool Xoa(ChatLieu chatLieu)
        {
            try
            {
                var CL = _dbContext.ChatLieus.Find(chatLieu.Id);
                if (CL != null)
                {
                    _dbContext.ChatLieus.Remove(CL);
                    _dbContext.SaveChanges();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
