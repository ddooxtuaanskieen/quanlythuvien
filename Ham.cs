using System;
using System.Collections.Generic;
using System.Drawing;
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
        public static int maxLate = 2;
        public static string defaultPassword = "00000000";
        public static string defaultNVImage = "https://i.imgur.com/LbORpEI.png";
        public static string defaultDGImage = "https://i.imgur.com/LbORpEI.png";
        public static string defaultSImage = "https://i.imgur.com/m13VNIS.png";

        public static int pricePerDay = 500;
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
                        .Select(x => new
                        {
                            x.MaNhanVien,
                            x.HoVaTen,
                            x.NguoiLap,
                            x.NgayLap
                        })
                        .ToList();
                //case "Q":
                //    return "Q" + (tv.QUYENs.Count() + 1).ToString();
                //case "PQ":
                //    return "PQ" + (tv.PHANQUYENs.Count() + 1).ToString();
                case "S":
                    return tv.SACHes
                        .Where(x => x.NgayXoa == null)
                        .Select(x => new
                        {
                            x.MaSach,
                            x.TieuDe,
                            x.NguoiLap,
                            x.NgayLap
                        })
                        .ToList();
                //case "TG":
                //    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                //case "ST":
                //    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                //case "TL":
                //    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                //case "PL":
                //    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                case "DG":
                    return tv.DOCGIAs
                        .Where(x => x.NgayXoa == null)
                        .Select(x => new
                        {
                            x.MaDocGia,
                            x.HoVaTen,
                            x.NguoiLap,
                            x.NgayLap
                        })
                        .ToList();
                case "MT":
                    return tv.MUONTRAs
                        .Select(x => new
                        {
                            x.MaMuonTra,
                            x.MaDocGia,
                            x.MaSach,
                            x.NguoiChoMuon,
                            x.NgayMuon,
                            x.NgayHenTra,
                            x.NguoiNhanTra,
                            x.NgayTra
                        })
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
                            && (x.MaNhanVien.ToLower().IndexOf(keyword.ToLower()) != -1 
                            || x.HoVaTen.ToLower().IndexOf(keyword.ToLower()) != -1))
                                .Select(x => new
                                {
                                    x.MaNhanVien,
                                    x.HoVaTen,
                                    x.NguoiLap,
                                    x.NgayLap
                                })
                            .ToList();
                    //case "Q":
                    //    return "Q" + (tv.QUYENs.Count() + 1).ToString();
                    //case "PQ":
                    //    return "PQ" + (tv.PHANQUYENs.Count() + 1).ToString();
                    case "S":
                        return tv.SACHes
                            .Where(x => (x.NgayXoa == null)
                            && (x.MaSach.ToLower().IndexOf(keyword.ToLower()) != -1
                            || x.TieuDe.ToLower().IndexOf(keyword.ToLower()) != -1))
                                .Select(x => new
                                {
                                    x.MaSach,
                                    x.TieuDe,
                                    x.NguoiLap,
                                    x.NgayLap
                                })
                            .ToList();
                    //case "TG":
                    //    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                    //case "ST":
                    //    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                    //case "TL":
                    //    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                    //case "PL":
                    //    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                    case "DG":
                        return tv.DOCGIAs
                            .Where(x => (x.NgayXoa == null)
                            && (x.MaDocGia.ToLower().IndexOf(keyword.ToLower()) != -1
                            || x.HoVaTen.ToLower().IndexOf(keyword.ToLower()) != -1))
                                .Select(x => new
                                {
                                    x.MaDocGia,
                                    x.HoVaTen,
                                    x.NguoiLap,
                                    x.NgayLap
                                })
                            .ToList();
                    case "MT":
                        return tv.MUONTRAs
                            .Where(x=> x.MaMuonTra.ToLower().IndexOf(keyword.ToLower()) != -1
                            || x.MaDocGia.ToLower().IndexOf(keyword.ToLower()) != -1
                            || x.MaSach.ToLower().IndexOf(keyword.ToLower()) != -1)
                                .Select(x => new
                                {
                                    x.MaMuonTra,
                                    x.MaDocGia,
                                    x.MaSach,
                                    x.NguoiChoMuon,
                                    x.NgayMuon,
                                    x.NgayHenTra,
                                    x.NguoiNhanTra,
                                    x.NgayTra
                                })
                            .ToList();
                    default:
                        return null;
                }
            }
        }
        public static bool deleteData(string obj, string id)
        {
            if (id == null || id == "")
            {
                MessageBox.Show("Vui lòng chọn đối tượng cần xóa.");
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
                    case "S":
                        {
                            SACH s = tv.SACHes
                                .Where(x => x.MaSach == id).SingleOrDefault();
                            s.NgayXoa = DateTime.Now;
                            break;
                        }
                    //case "TG":
                    //    return "TG" + (tv.TACGIAs.Count() + 1).ToString();
                    //case "ST":
                    //    return "ST" + (tv.SANGTACs.Count() + 1).ToString();
                    //case "TL":
                    //    return "TL" + (tv.THELOAIs.Count() + 1).ToString();
                    //case "PL":
                    //    return "PL" + (tv.PHANLOAIs.Count() + 1).ToString();
                    case "DG":
                        {
                            DOCGIA dg = tv.DOCGIAs
                                .Where(x => x.MaDocGia == id).SingleOrDefault();
                            dg.NgayXoa = DateTime.Now;
                            break;
                        }
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
                MessageBox.Show("Xóa đối tượng thành công.");
                return true;
            }

        }
        public static int getFine(string maMuonTra)
        {
            MUONTRA mt = tv.MUONTRAs.Where(x => x.MaMuonTra == maMuonTra).SingleOrDefault();
            return mt.NgayTra < mt.NgayHenTra ? 
                0 :
                pricePerDay * (int)((DateTime)mt.NgayTra - mt.NgayHenTra).TotalDays;
        }
    }
}
