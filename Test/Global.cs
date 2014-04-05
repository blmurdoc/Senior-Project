using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Global
/// </summary>
public class Global
{
    public ServerInterface ServerInterface
    {
        get
        {
            if(_serverInterface == null)
                _serverInterface = new ServerInterface();
            return _serverInterface;
        }
    }
    private ServerInterface _serverInterface;
}