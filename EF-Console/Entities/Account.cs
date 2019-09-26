using System;
using System.Collections.Generic;

namespace EF_Console.Entities
{
    public class Account
    {
        public string Id { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public DateTime CreatedTime { get; protected set; }

        public string OrganizationId { get; protected set; }
        public Organization Organization { get; protected set; }

        public List<AccountTag> OwnAccountTags { get; protected set; }

        //public AccountType AccountType { get; protected set; }
        //protected int _AccountTypeId;

        #region ctor
        protected Account()
        {
            OwnAccountTags = new List<AccountTag>();
        }

        public Account(string name)
            : this()
        {
            Name = name;
            CreatedTime = DateTime.Now;
            //_AccountTypeId = accountType.Id;
        }
        #endregion

        public void SetDescription(string description)
        {
            Description = description;
        }

        public void AddTag(Tag tag)
        {
            var at = new AccountTag();
            at.Account = this;
            at.Tag = tag;
            OwnAccountTags.Add(at);
        }
    }
}
