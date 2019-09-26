using EF_Console.Commons;

namespace EF_Console.Entities
{
    public class AccountType : Enumeration
    {
        public static AccountType ApplicationAdmin = new ApplicationAdminType();
        public static AccountType Admin = new AdminType();
        public static AccountType Normal = new NormalType();

        public AccountType(int id, string name)
            : base(id, name)
        {
        }

        private class ApplicationAdminType : AccountType
        {
            public ApplicationAdminType()
              : base(1, "超级管理员")
            {
            }
        }

        private class AdminType : AccountType
        {
            public AdminType()
              : base(2, "管理员")
            {
            }
        }

        private class NormalType : AccountType
        {
            public NormalType()
              : base(3, "普通用户")
            {
            }
        }
    }
}
