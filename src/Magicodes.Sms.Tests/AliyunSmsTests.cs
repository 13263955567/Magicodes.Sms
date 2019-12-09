using System;
using Magicodes.Sms.Aliyun;
using Magicodes.Sms.Aliyun.Builder;
using Magicodes.Sms.Tests.Helper;
using Xunit;
using Shouldly;
using System.Threading.Tasks;

namespace Magicodes.Sms.Tests
{
    public class AliyunSmsTests
    {
        static AliyunSmsTests() =>
            AliyunSmsBuilder.Create()
                //������־��¼
                .WithLoggerAction((tag, message) =>
                {
                    Console.WriteLine(string.Format("Tag:{0}\tMessage:{1}", tag, message));
                }).SetSettingsFunc(() =>
                {
                    //TODO:�����������Լ�������
                    //�����һ����Ŀ�������,��ʹ��key����ȡ�������
                    return ConfigHelper.LoadConfig("aliyun_app");
                }).Build();


        [Theory(DisplayName = "���ŷ��Ͳ���")]
        [InlineData("����ֻ�����", "��֤��")]
        public async Task SendCodeAsync_Test(string phone, string code)
        {
            var smsService = new AliyunSmsService();
            var result = await smsService.SendCodeAsync(phone, code);
            result.Success.ShouldBeTrue();
        }
    }
}
