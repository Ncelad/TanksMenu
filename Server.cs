using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TanksMenu
{
    class Server : IService
    {
        BasicHttpBinding httpBinding = new BasicHttpBinding();
        EndpointAddress address = new EndpointAddress("http://ionc0re-001-site1.ftempurl.com/Service.svc");

        public string Register(string email, string password, string password_check)
        {
            using(var channelFactory = new ChannelFactory<IService>(httpBinding, address))
            {
                IService client = null;
                try
                {
                    client = channelFactory.CreateChannel();
                    string result = client.Register(email, password, password_check);
                    (client as ICommunicationObject).Close();
                    channelFactory.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    (client as ICommunicationObject)?.Abort();
                    return ex.Message;
                }
            }
        }

        public string Login(string email, string password)
        {
            using (var channelFactory = new ChannelFactory<IService>(httpBinding, address))
            {
                IService client = null;
                try
                {
                    client = channelFactory.CreateChannel();
                    string result = client.Login(email, password);
                    (client as ICommunicationObject).Close();
                    channelFactory.Close();
                    return result;
                }
                catch (Exception ex)
                {
                    (client as ICommunicationObject)?.Abort();
                    return ex.Message;
                }
            }
        }
    }
}
