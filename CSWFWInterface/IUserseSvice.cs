using System;
using System.Collections.Generic;
using System.Text;
using CSWFWModel;
namespace CSWFWInterface
{
    public interface IUserseSvice
    {

        List<User> getAllUser();
        User getUser(string name);
    }
}
