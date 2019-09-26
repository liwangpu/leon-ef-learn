using System;

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


        #region ctor
        protected Account()
        {

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

    }
}
