using System;

/// <summary>
/// Summary description for Class1
/// </summary>

    public class Passport
    {
        private string id;
        private string firstName;
        private string lastName;
        private Date birthDate;
        private string homeland;
        private string nation;
        private string maritalStatus;
        private string residentialAddress;
        private string[] childId;

        public Passport()
        {
            this.childId = new string[3];
        }

        public Passport(string id, string firstName, string lastName, Date birthDate,
                        string homeland, string nation, string maritalStatus, string residentialAddress)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
            this.homeland = homeland;
            this.nation = nation;
            this.maritalStatus = maritalStatus;
            this.residentialAddress = residentialAddress;
            this.childId = new string[3];
        }

        public string GetId()
        {
            return this.id;
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public string GetFirstName()
        {
            return this.firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetLastName()
        {
            return this.lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public Date GetBirthDate()
        {
            return this.birthDate;
        }

        public void SetBirthDate(Date birthDate)
        {
            this.birthDate = birthDate;
        }

        public string GetHomeland()
        {
            return this.homeland;
        }

        public void SetHomeland(string homeland)
        {
            this.homeland = homeland;
        }

        public string GetNation()
        {
            return this.nation;
        }

        public void SetNation(string nation)
        {
            this.nation = nation;
        }

        public string GetMaritalStatus()
        {
            return this.maritalStatus;
        }

        public void SetMaritalStatus(string maritalStatus)
        {
            this.maritalStatus = maritalStatus;
        }

        public string GetResidentialAddress()
        {
            return this.residentialAddress;
        }

        public void SetResidentialAddress(string residentialAddress)
        {
            this.residentialAddress = residentialAddress;
        }

        public string[] GetChildId()
        {
            return this.childId;
        }

        public void SetChildId(string[] childId)
        {
            this.childId = childId;
        }

        public bool AddChild(string newChildId, int childAge)
        {
            if (childAge < 0 || childAge > 15)
            {
                return false;
            }

            for (int i = 0; i < this.childId.Length; i++)
            {
                if (this.childId[i] == null)
                {
                    this.childId[i] = newChildId;
                    return true;
                }
            }

            return false;
        }

        public bool RemoveAdultChild(string targetChildId, int currentAge)
        {
            if (currentAge < 15)
            {
                return false;
            }

            for (int i = 0; i < this.childId.Length; i++)
            {
                if (this.childId[i] != null && this.childId[i] == targetChildId)
                {
                    this.childId[i] = null;
                    return true;
                }
            }

            return false;
        }
    }
