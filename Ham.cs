using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using QUANLYTHUVIEN.Models;

namespace QUANLYTHUVIEN
{
    public static class Ham
    {
        public static string currentUser = "";
        public static QUANLYTHUVIENEntities tv = new QUANLYTHUVIENEntities();
        public static string generateID(string obj)
        {
            switch (obj)
            {
                case "NV":
                    return "NV" + (tv.NHANVIENs.Count() + 1).ToString();
                default:
                    return null;
            }
        }
        public static string getMD5(string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bHash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sbHash = new StringBuilder();
            foreach (byte b in bHash)
            {
                sbHash.Append(String.Format("{0:x2}", b));
            }
            return sbHash.ToString();
        }
        public static IEnumerable<Object> getAllData(string obj)
        {
            switch (obj)
            {
                case "NV":
                    return tv.NHANVIENs
                        .Where(x => x.NgayXoa == null)
                        .Select(x => new { x.MaNhanVien, x.HoVaTen, x.SoCMT, x.NgaySinh, x.DiaChi, x.SoDienThoai, x.Email, x.MatKhau, x.Anh, x.NguoiLap, x.NgayLap })
                        .ToList();
                default:
                    return null;
            }
        }
        public static IEnumerable<SACH> getAvailableBooks()
        {
            List<String> unavailableBooks = new List<string>();
            foreach (var item in tv.MUONTRAs.Where(x => x.NgayTra == null).ToList())
            {
                unavailableBooks.Add(item.MaSach);
            }
            //return tv.SACHes.Where(x => unavailableBooks.IndexOf(x.MaSach) == -1).ToList();
            return from sach in tv.SACHes
                   where unavailableBooks.IndexOf(sach.MaSach) == -1
                   select sach;
        }
        public static IEnumerable<Object> getData(string obj, string keyword)
        {
            switch (obj)
            {
                case "NV":
                    return tv.NHANVIENs
                        .Where(x => (x.NgayXoa == null) && (x.HoVaTen.ToLower().IndexOf(keyword.ToLower())!= -1))
                        .Select(x => new { x.MaNhanVien, x.HoVaTen, x.SoCMT, x.NgaySinh, x.DiaChi, x.SoDienThoai, x.Email, x.MatKhau, x.Anh, x.NguoiLap, x.NgayLap })
                        .ToList();
                default:
                    return null;
            }
        }
        public static bool deleteData(string obj, string id)
        {
            switch (obj)
            {
                case "NV":
                    {
                        NHANVIEN nv = tv.NHANVIENs
                            .Where(x => x.MaNhanVien == id).SingleOrDefault();
                        tv.NHANVIENs.Remove(nv);
                        tv.SaveChanges();
                        return true;
                    }
                default:
                    return false;
            }
        }
    }
}
