using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QUANLYTHUVIEN.Models;
using System.Web;
using System.Net;
using System.Net.Mail;

namespace QUANLYTHUVIEN
{
    public static class Ham
    {
        public static string currentUser = null; //Mã người dùng hiện tại
        public static int maxBookHold = 2; //Trong 1 thời điểm, 1 độc giả được mượn nhiều nhất 2 quyển
        public static int maxLate = 2; //Trả muộn sách 2 lần là vào danh sách đen
        public static int joinFare = 100000; //Phí đăng ký thẻ độc giả trong 1 năm
        public static string defaultPassword = "00000000"; //Mật khẩu mặc định
        public static int pricePerDay = 500; //Phí mượn 1 ngày
        public static double percentPricePerRent = 0.8; //Cọc 80% giá trị sách
        public static double percentPricePerLateDay = 0.01; //Mỗi ngày muộn phạt 1% giá trị sách

        public static DateTime lastDaySendReminder = new DateTime(2020, 06, 21);

        public static string defaultNVImage = "https://i.imgur.com/LbORpEI.png";
        public static string defaultDGImage = "https://i.imgur.com/LbORpEI.png";
        public static string defaultSImage = "https://i.imgur.com/m13VNIS.png";
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
                            x.NgayTra,
                            x.Phi,
                            x.Phat
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
                                    x.NgayTra,
                                    x.Phi,
                                    x.Phat
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
        public static int getCostRent(string maMuonTra)
        {
            MUONTRA mt = tv.MUONTRAs.Where(x => x.MaMuonTra == maMuonTra).SingleOrDefault();
            return DateTime.Now <= mt.NgayHenTra ?
                pricePerDay * (int)(DateTime.Now - (DateTime)mt.NgayMuon).TotalDays :
                pricePerDay * (int)((DateTime)mt.NgayHenTra - (DateTime)mt.NgayMuon).TotalDays;
        }
        public static double getFine(string maMuonTra)
        {
            MUONTRA mt = tv.MUONTRAs.Where(x => x.MaMuonTra == maMuonTra).SingleOrDefault();
            int bookPrice = tv.SACHes.Where(x => x.MaSach == mt.MaSach).SingleOrDefault().Gia;
            return DateTime.Now <= mt.NgayHenTra ? 
                0 :
                percentPricePerLateDay * bookPrice * (int)(DateTime.Now - (DateTime)mt.NgayHenTra).TotalDays;
        }
        public static void sendEmailRemindMuon(string maMuonTra)
        {
            MUONTRA mt = Ham.tv.MUONTRAs.Where(x => x.MaMuonTra == maMuonTra).SingleOrDefault();
            string tenDocGia = tv.DOCGIAs.Where(x => x.MaDocGia == mt.MaDocGia).SingleOrDefault().HoVaTen;
            string emailDocGia = tv.DOCGIAs.Where(x => x.MaDocGia == mt.MaDocGia).SingleOrDefault().Email;
            string tenSach = tv.SACHes.Where(x=>x.MaSach == mt.MaSach).SingleOrDefault().TieuDe;
            int thoiHan = (int)(DateTime.Now - (DateTime)mt.NgayHenTra).TotalDays;

            string subject = "Nhắc nhở trả sách";
            string body = "Thư viện gửi đến bạn " + tenDocGia + " nhắc nhở trả sách đúng hạn" + "\n"
                + "Mã phiếu mượn: " + maMuonTra + "\n"
                + "Mã độc giả: " + mt.MaDocGia + "\n"
                + "Tên độc giả: " + tenDocGia + "\n"
                + "Mã sách: " + mt.MaSach + "\n"
                + "Tên sách: " + tenSach + "\n"
                + "Hạn trả sách: " + mt.NgayHenTra.ToString() + "\n"
                + "Thời gian còn: " + (Math.Abs(thoiHan)).ToString() + " ngày" + "\n"
                + "Vui lòng sắp xếp thời gian trả sách đúng thời hạn." + "\n"
                + "Thư viện xin cảm ơn!";
            string username = "ddooxtuaanskieen@gmail.com";
            string password = "Kien72381997";
            MailMessage mail = new MailMessage(username, emailDocGia, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(username, password);
            client.EnableSsl = true;
            client.Send(mail);
        }
        public static void sendEmailRemindTheDocGia(string maDocGia)
        {
            THEDOCGIA tdg = Ham.tv.THEDOCGIAs.Where(x => x.MaDocGia == maDocGia)
                .OrderByDescending(y => y.NgayGiaHan)
                .FirstOrDefault();
            DateTime hanThe = (DateTime)tdg.HanMoi;
            string tenDocGia = tv.DOCGIAs.Where(x => x.MaDocGia == maDocGia).SingleOrDefault().HoVaTen;
            string emailDocGia = tv.DOCGIAs.Where(x => x.MaDocGia == maDocGia).SingleOrDefault().Email;
            int thoiHan = (int)(DateTime.Now - hanThe).TotalDays;

            string subject = "Nhắc nhở gia hạn thẻ độc giả";
            string body = "Thư viện gửi đến bạn " + tenDocGia + " nhắc nhở gia hạn thẻ độc giả" + "\n"
                + "Mã độc giả: " + maDocGia + "\n"
                + "Tên độc giả: " + tenDocGia + "\n"
                + "Hạn thẻ: " + hanThe.ToString() + "\n"
                + "Thời gian còn: " + (Math.Abs(thoiHan)).ToString() + " ngày" + "\n"
                + "Vui lòng sắp xếp thời gian gia hạn thẻ độc giả để tiếp tục sử dụng các dịch vụ của thư viện." + "\n"
                + "Thư viện xin cảm ơn!";
            string username = "ddooxtuaanskieen@gmail.com";
            string password = "Kien72381997";
            MailMessage mail = new MailMessage(username, emailDocGia, subject, body);
            SmtpClient client = new SmtpClient("smtp.gmail.com");
            client.Port = 587;
            client.Credentials = new System.Net.NetworkCredential(username, password);
            client.EnableSsl = true;
            client.Send(mail);
        }
        public static void openFormInPanel(Form myForm, Panel MyPanel)
        {
            MyPanel.Controls.Clear();
            myForm.TopLevel = false;
            myForm.FormBorderStyle = FormBorderStyle.None;
            myForm.Dock = DockStyle.Fill;
            MyPanel.Controls.Add(myForm);
            MyPanel.Tag = myForm;
            myForm.BringToFront();
            myForm.Show();
        }
    }
}
