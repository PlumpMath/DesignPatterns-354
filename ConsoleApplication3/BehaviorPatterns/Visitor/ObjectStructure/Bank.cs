using System.Collections.Generic;
using DesignPatterns.BehaviorPatterns.Visitor.Element;
using DesignPatterns.BehaviorPatterns.Visitor.Visitors;

namespace DesignPatterns.BehaviorPatterns.Visitor.ObjectStructure
{
    public class Bank
    {
        private readonly List<IAccount> _accounts;

        public Bank()
        {
            _accounts = new List<IAccount>();
        }

        public void AddAccount(IAccount account)
        {
            _accounts.Add(account);
        }

        public void RemoveAccount(IAccount account)
        {
            _accounts.Remove(account);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (var account in _accounts)
            {
                account.Accept(visitor);
            }
        }
    }
}