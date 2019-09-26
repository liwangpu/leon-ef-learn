using System;
using System.Collections.Generic;

namespace EF_Console.Entities
{
    public class Organization
    {
        private readonly List<Account> _ownAccounts;
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public DateTime CreatedTime { get; protected set; }

        public IReadOnlyCollection<Account> OwnAccounts => _ownAccounts;

        #region ctor
        protected Organization()
        {
            CreatedTime = DateTime.Now;
            _ownAccounts = new List<Account>();
        }

        public Organization(string name)
            : this()
        {
            Name = name;

        }
        #endregion

        public void AddAccount(Account account)
        {
            _ownAccounts.Add(account);
        }
    }
}
