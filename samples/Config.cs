using System;
using Aliyun.OSS.Common;

namespace Aliyun.OSS.Samples
{
    internal class Config
    {
        public static string AccessKeyId = "LTAI9LdQf0B57x2H";

        public static string AccessKeySecret = "YNWmOOR6G1E1HjcN2uRpjtCDLg8v0K";

        public static string Endpoint = "http://oss-cn-beijing.aliyuncs.com";

        public static string DirToDownload = @"F:\demo1";

        public static string FileToUpload = @"F:\demo1\72.pdf";

        public static string BigFileToUpload = @"F:\demo1\72.pdf";
        public static string ImageFileToUpload = @"F:\demo1";
        public static string CallbackServer = "<your callback server uri>";
    }
}