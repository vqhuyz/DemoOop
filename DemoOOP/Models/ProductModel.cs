using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoOOP.Models
{
    public class ProductModel : BaseProduct
    {
        public override int Id { get; set; }
        public override DateTime CreateAt { get; set; }

        private Nullable<bool> _active;
        private string _name;
        private string _manufacture;
        private string _createdBy;
        private string _description;
        private string _updatedBy;

        public string Name
        {
            set { this._name = value; }
            get { return this._name; }
        }

        public void SetName(string name)
        {
            this._name = name;
        }
        public string GetName()
        {
            return this._name;
        }

        public string Description
        {
            set { this._description = value; }
            get { return this._description; }
        }

        public void SetDescription(string description)
        {
            this._description = description;
        }
        public string GetDescription()
        {
            return this._description;
        }

        public string Manufaceture
        {
            set { this._manufacture = value; }
            get { return this._manufacture; }
        }

        public void SetManufacture(string manufacture)
        {
            this._manufacture = manufacture;
        }
        public string GetManufacture()
        {
            return this._manufacture;
        }


        public string CreatedBy
        {
            set { this._createdBy = value; }
            get { return this._createdBy; }
        }

        public void SetCreatedBy(string createdBy)
        {
            this._createdBy = createdBy;
        }
        public string GetCreatedBy()
        {
            return this._createdBy;
        }

        public string UpdatedBy
        {
            set { this._updatedBy = value; }
            get { return this._updatedBy; }
        }

        public void SetUpdatedBy(string updatedBy)
        {
            this._updatedBy = updatedBy;
        }
        public string GetUpdatedBy()
        {
            return this._updatedBy;
        }

        public bool? Active
        {
            set { this._active = value; }
            get { return this._active; }
        }

        public void SetActive(bool? active)
        {
            this._active = active;
        }
        public bool? GetActive()
        {
            return this._active;
        }
    }
}