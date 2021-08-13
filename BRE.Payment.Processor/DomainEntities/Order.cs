using System;
using System.Collections.Generic;
using System.Text;

namespace BRE.Payment.Processor.DomainEntities
{
    public class Order
    {
        public Order() { }
        public Order( User user,  Items[] items,  Agent agent)
        {
     
        _items = items;

        _user = user;
        _agent = agent;

        _gifts = new List<string>();
    }

    private User _user;
    public User getuser()
    {
        return _user;
    }

    private Items[] _items;
    public Items[] getItems()
    {
        return _items;
    }

    private  Agent _agent;
	public Agent getAgent()
    {
        return _agent;
    }

    private List<String> _gifts;
    public void addGifts(String gift)
    {
        if (!_gifts.Contains(gift))
                _gifts.Add(gift);
    }

    public string[] getGifts()
    {
        return _gifts.ToArray();
    }
}
}
