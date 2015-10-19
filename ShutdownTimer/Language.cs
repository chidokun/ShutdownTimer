using System.Collections.Generic;

namespace ShutdownTimer
{
    public enum LanguageName { English, Vietnamese};

    public class Language
    {
        
        /// <summary>
        /// Contains language content
        /// </summary>
        public Dictionary<string, string> Items { get; set; }
        
        /// <summary>
        /// Initialize language content
        /// </summary>
        /// <param name="langName"></param>
        public Language(LanguageName langName)
        {
            Items = new Dictionary<string, string>();
            switch (langName)
            {
                case LanguageName.Vietnamese:
                    Vietnamese();
                    break;
                case LanguageName.English:
                    English();
                    break;
            }
        }

        public void English()
        {
            Items.Add("Main.Bar.PowerMenu.Shutdown", "Shutdown Now");
            Items.Add("Main.Bar.PowerMenu.Restart", "Restart Now");
            Items.Add("Main.GroupBoxTime.Title", "Set time");
            Items.Add("Main.ButtonSet", "Set");
            Items.Add("Main.ButtonCancel", "Cancel");
            Items.Add("Main.Option.Title", "Options");
            Items.Add("Main.Option.Radio.Shutdown", "Shutdown");
            Items.Add("Main.Option.Radio.Restart", "Restart");
            Items.Add("Main.Option.Radio.SignOut", "Sign out");
            Items.Add("Main.Option.Check.UseHybridBoot", "Use Hybrid boot");
            Items.Add("Main.Option.Check.ForceStop", "Force stop");
            Items.Add("Main.Option.Check.UseVietnamese", "Use Vietnamese interface");
            Items.Add("Main.Option.Check.WarnBefore", "Warn before:");
            Items.Add("Main.Option.Check.minute", "minute(s)");
            Items.Add("Main.Run.TimeRemaining", "Time remaining:");

            Items.Add("Notification.Options", "Options");
            Items.Add("Notification.Shutdown", "Shutdown now");
            Items.Add("Notification.Restart", "Restart now");
            Items.Add("Notification.Exit", "Exit");
            Items.Add("Notification.Balloon.Warn.Title", "You're about to be signed out");
            Items.Add("Notification.Balloon.Warn.Detail", "About {0} minute(s) remaining");

            Items.Add("Status.Default", "Set time then click Set to start the task");
            Items.Add("Status.TaskCompleted", "Time was set. Click Cancel to cancel this task");

            Items.Add("Message.Exit.Title", "Exit program");
            Items.Add("Message.Exit.Text", "Do you want to cancel and exit program?");

            Items.Add("About.Title", "About");
            Items.Add("About.Version", "Version: ");
            Items.Add("About.ButtonClose", "Close");
        }

        public void Vietnamese()
        {
            Items.Add("Main.Bar.PowerMenu.Shutdown", "Tắt máy ngay");
            Items.Add("Main.Bar.PowerMenu.Restart", "Khởi động lại ngay");
            Items.Add("Main.GroupBoxTime.Title", "Đặt giờ");
            Items.Add("Main.ButtonSet", "Đặt giờ");
            Items.Add("Main.ButtonCancel", "Hủy bỏ");
            Items.Add("Main.Option.Title", "Tùy chọn");
            Items.Add("Main.Option.Radio.Shutdown", "Tắt máy");
            Items.Add("Main.Option.Radio.Restart", "Khởi động lại");
            Items.Add("Main.Option.Radio.SignOut", "Đăng xuất");
            Items.Add("Main.Option.Check.UseHybridBoot", "Dùng Hybrid boot");
            Items.Add("Main.Option.Check.ForceStop", "Buộc dừng");
            Items.Add("Main.Option.Check.UseVietnamese", "Dùng giao diện tiếng Việt");
            Items.Add("Main.Option.Check.WarnBefore", "Nhắc trước:");
            Items.Add("Main.Option.Check.minute", "phút");
            Items.Add("Main.Run.TimeRemaining", "Thời gian chờ:");

            Items.Add("Notification.Options", "Tùy chọn");
            Items.Add("Notification.Shutdown", "Tắt máy ngay");
            Items.Add("Notification.Restart", "Khởi động lại ngay");
            Items.Add("Notification.Exit", "Thoát");
            Items.Add("Notification.Balloon.Warn.Title", "Bạn chuẩn bị đăng xuất");
            Items.Add("Notification.Balloon.Warn.Detail", "Còn lại khoảng {0} phút");

            Items.Add("Status.Default", "Chọn giờ sau đó bấm \"Đặt giờ\" để bắt đầu");
            Items.Add("Status.TaskCompleted", "Đã đặt giờ. Bấm \"Hủy bỏ\" để hủy tác vụ");

            Items.Add("Message.Exit.Title", "Thoát chương trình");
            Items.Add("Message.Exit.Text", "Bạn có muốn hủy đặt giờ và thoát chương trình?");

            Items.Add("About.Title", "Thông tin");
            Items.Add("About.Version", "Phiên bản: ");
            Items.Add("About.ButtonClose", "Đóng");
        }
    }
}
