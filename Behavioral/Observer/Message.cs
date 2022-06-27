using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Fundamentos.DesignPatterns.Behavioral.Observer.Interfaces;

namespace Fundamentos.DesignPatterns.Behavioral.Observer
{
  public class Message : IMessage
  {

    public Message(string body, DateTime publishHour)
    {
      Body = body;
      PublishHour = publishHour;
    }
    public string Body { get; set; }
    public DateTime PublishHour { get; set; }


  }
}