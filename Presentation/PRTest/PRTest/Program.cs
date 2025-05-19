using MailKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using PRTest;

var messageToSend = new MimeMessage();
messageToSend.From.Add(new MailboxAddress("Damian Dan", PrivateData.EmailAddress));
messageToSend.To.Add(new MailboxAddress("Damian Dan", PrivateData.EmailAddress));
messageToSend.Subject = "Damian Dan";
messageToSend.Body = new TextPart("plain")
{
    Text = "This is a test message"
};

var smtpClient = new SmtpClient();
smtpClient.Connect(PublicData.OutgoingMailServer, PublicData.OutgoingMailServerPort, SecureSocketOptions.SslOnConnect);
smtpClient.Authenticate(PrivateData.EmailAddress, PrivateData.Password);
smtpClient.Send(messageToSend);

var iMapClient = new ImapClient();
iMapClient.Connect(
    PublicData.IncomingIMapServer,
    PublicData.IncomingIMapServerPort,
    SecureSocketOptions.SslOnConnect);

iMapClient.Authenticate(PrivateData.EmailAddress, PrivateData.Password);

var inbox = iMapClient.Inbox;
inbox.Open(FolderAccess.ReadOnly);

var lastmessage = inbox.GetMessage(inbox.Count - 1);
Console.WriteLine(lastmessage.Subject);
iMapClient.Disconnect(true);

var pop3Client = new Pop3Client();

pop3Client.Connect(PublicData.IncomingPop3Server, PublicData.IncomingPop3ServerPort, SecureSocketOptions.SslOnConnect);
pop3Client.Authenticate(PrivateData.EmailAddress, PrivateData.Password);

lastmessage = pop3Client.GetMessage(pop3Client.Count - 1);
Console.WriteLine(lastmessage.Subject);

