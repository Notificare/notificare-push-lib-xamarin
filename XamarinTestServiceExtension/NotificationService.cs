using System;
using Foundation;
using UIKit;
using UserNotifications;
using Notificare.iOS;

namespace XamarinTestServiceExtension
{
    [Register("NotificationService")]
    public class NotificationService : UNNotificationServiceExtension
    {
        Action<UNNotificationContent> ContentHandler { get; set; }
        UNMutableNotificationContent BestAttemptContent { get; set; }

        protected NotificationService(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void DidReceiveNotificationRequest(UNNotificationRequest request, Action<UNNotificationContent> contentHandler)
        {
            Console.WriteLine("Notification Service DidReceiveNotificationRequest: {0}", request);
            ContentHandler = contentHandler;
            BestAttemptContent = (UNMutableNotificationContent)request.Content.MutableCopy();
            NotificarePushLib.Shared().FetchAttachment(request.Content.UserInfo, (NSArray info) =>
            {
                BestAttemptContent.Attachments = NSArray.FromArray<UNNotificationAttachment>(info);
                ContentHandler(BestAttemptContent);
            }, (NSError error) =>
            {
                ContentHandler(BestAttemptContent);
            });
        }

        public override void TimeWillExpire()
        {
            // Called just before the extension will be terminated by the system.
            // Use this as an opportunity to deliver your "best attempt" at modified content, otherwise the original push payload will be used.

            ContentHandler(BestAttemptContent);
        }
    }
}
