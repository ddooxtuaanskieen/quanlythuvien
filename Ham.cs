using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.Models;

namespace QUANLYTHUVIEN
{
    public static class Ham
    {
        public static string currentUser = null;
        public static int maxBookHold = 2;
        public static QUANLYTHUVIENEntities tv = new QUANLYTHUVIENEntities();
        public static string generateID(string obj)
        {
            switch (obj)
            {
                case "NV":
                    return "NV" + (tv.NHANVIENs.Count() + 1).ToString();
                case "Q":
                    return "Q" + (tv.QUYENs.Count() + 1).ToString();
                case "PQ":
                    return "PQ" + (tv.PHANQUYENs.Count() + 1).ToString();
                case "S":
                    return "S" + (tv.SACHes.Count() + 1).ToString();
                case "TG":
                    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                case "ST":
                    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                case "TL":
                    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                case "PL":
                    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                case "DG":
                    return "DG" + (tv.DOCGIAs.Count() + 1).ToString();
                case "MT":
                    return "MT" + (tv.MUONTRAs.Count() + 1).ToString();
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
                //case "Q":
                //    return "Q" + (tv.QUYENs.Count() + 1).ToString();
                //case "PQ":
                //    return "PQ" + (tv.PHANQUYENs.Count() + 1).ToString();
                //case "S":
                //    return "S" + (tv.SACHes.Count() + 1).ToString();
                //case "TG":
                //    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                //case "ST":
                //    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                //case "TL":
                //    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                //case "PL":
                //    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                //case "DG":
                //    return "DG" + (tv.DOCGIAs.Count() + 1).ToString();
                case "MT":
                    return tv.MUONTRAs
                        .Select(x => new { x.MaMuonTra, x.MaDocGia, x.MaSach, x.NguoiChoMuon, x.NgayMuon, x.NgayHenTra, x.NguoiNhanTra, x.NgayTra})
                        .ToList();
                default:
                    return null;
            }
        }

        public static IEnumerable<Object> getData(string obj, string keyword)
        {
            if (keyword == null || keyword == "")
                return getAllData(obj);
            else
            {
                switch (obj)
                {
                    case "NV":
                        return tv.NHANVIENs
                            .Where(x => (x.NgayXoa == null) 
                            && (x.MaNhanVien.ToLower().IndexOf(keyword.ToLower()) != -1 || x.HoVaTen.ToLower().IndexOf(keyword.ToLower()) != -1))
                            .Select(x => new { x.MaNhanVien, x.HoVaTen, x.SoCMT, x.NgaySinh, x.DiaChi, x.SoDienThoai, x.Email, x.MatKhau, x.Anh, x.NguoiLap, x.NgayLap })
                            .ToList();
                    //case "Q":
                    //    return "Q" + (tv.QUYENs.Count() + 1).ToString();
                    //case "PQ":
                    //    return "PQ" + (tv.PHANQUYENs.Count() + 1).ToString();
                    //case "S":
                    //    return "S" + (tv.SACHes.Count() + 1).ToString();
                    //case "TG":
                    //    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                    //case "ST":
                    //    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                    //case "TL":
                    //    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                    //case "PL":
                    //    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                    //case "DG":
                    //    return "DG" + (tv.DOCGIAs.Count() + 1).ToString();
                    //case "MT":
                    //    return "MT" + (tv.MUONTRAs.Count() + 1).ToString();
                    default:
                        return null;
                }
            }
        }
        public static bool deleteData(string obj, string id)
        {
            if(id == null || id == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần xóa");
                return false;
            }
            else
            {
                switch (obj)
                {
                    case "NV":
                        {
                            NHANVIEN nv = tv.NHANVIENs
                                .Where(x => x.MaNhanVien == id).SingleOrDefault();
                            nv.NgayXoa = DateTime.Now;
                            break;
                        }
                    //case "Q":
                    //    return "Q" + (tv.QUYENs.Count() + 1).ToString();
                    //case "PQ":
                    //    return "PQ" + (tv.PHANQUYENs.Count() + 1).ToString();
                    //case "S":
                    //    return "S" + (tv.SACHes.Count() + 1).ToString();
                    //case "TG":
                    //    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                    //case "ST":
                    //    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                    //case "TL":
                    //    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                    //case "PL":
                    //    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                    //case "DG":
                    //    return "DG" + (tv.DOCGIAs.Count() + 1).ToString();
                    case "MT":
                        {
                            MUONTRA mt = tv.MUONTRAs
                                .Where(x => x.MaMuonTra == id).SingleOrDefault();
                            tv.MUONTRAs.Remove(mt);
                            break;
                        }
                    default:
                        return false;
                }
                tv.SaveChanges();
                return true;
            }
            
        }
        public static int getFine(string maMuon)
        {
            MUONTRA mt = tv.MUONTRAs.Where(x => x.MaMuonTra == maMuon).SingleOrDefault();
            if (mt.NgayTra < mt.NgayHenTra) return 0;
            else return 500 * (int)((DateTime)mt.NgayTra - mt.NgayHenTra).TotalDays;
        }
    }
}
