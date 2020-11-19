namespace command
{
    public class SmsJob : IJob
    {
        private Sms _sms;
        public void Run()
        {
            _sms.SendSms();
        }

        public void Sms(Sms sms)
        {
            _sms = sms;
        }
    }
}