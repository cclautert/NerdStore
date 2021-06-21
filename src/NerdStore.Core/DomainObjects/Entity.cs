using System;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        private Guid _Id;
        public Guid Id {
            get { return _Id; }
            set { _Id = value; }
        }

        protected Entity()
        {
            _Id = Guid.NewGuid();
        }

        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return _Id.Equals(compareTo._Id);
        }

        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;
            if (ReferenceEquals(a, null) | ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + _Id.GetHashCode();
        }

        public override string ToString()
        {
            return GetType().Name + " [Id=" + _Id + "]";
        }

        public virtual bool EhValido()
        {
            throw new NotImplementedException(); 
        }
    }
}
