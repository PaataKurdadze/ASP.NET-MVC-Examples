#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Basket.Models
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebPage")]
	public partial class MydbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertproduct_new(product_new instance);
    partial void Updateproduct_new(product_new instance);
    partial void Deleteproduct_new(product_new instance);
    partial void Insertuser_cart(user_cart instance);
    partial void Updateuser_cart(user_cart instance);
    partial void Deleteuser_cart(user_cart instance);
    #endregion
		
		public MydbDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebPageConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public MydbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<product_new> product_news
		{
			get
			{
				return this.GetTable<product_new>();
			}
		}
		
		public System.Data.Linq.Table<user_cart> user_carts
		{
			get
			{
				return this.GetTable<user_cart>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.product_new")]
	public partial class product_new : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Name;
		
		private string _Store;
		
		private decimal _Price;
		
		private EntitySet<user_cart> _user_carts;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnStoreChanging(string value);
    partial void OnStoreChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    #endregion
		
		public product_new()
		{
			this._user_carts = new EntitySet<user_cart>(new Action<user_cart>(this.attach_user_carts), new Action<user_cart>(this.detach_user_carts));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Store", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Store
		{
			get
			{
				return this._Store;
			}
			set
			{
				if ((this._Store != value))
				{
					this.OnStoreChanging(value);
					this.SendPropertyChanging();
					this._Store = value;
					this.SendPropertyChanged("Store");
					this.OnStoreChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="SmallMoney NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_new_user_cart", Storage="_user_carts", ThisKey="Id", OtherKey="ProductId")]
		public EntitySet<user_cart> user_carts
		{
			get
			{
				return this._user_carts;
			}
			set
			{
				this._user_carts.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_user_carts(user_cart entity)
		{
			this.SendPropertyChanging();
			entity.product_new = this;
		}
		
		private void detach_user_carts(user_cart entity)
		{
			this.SendPropertyChanging();
			entity.product_new = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.user_cart")]
	public partial class user_cart : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _UserId;
		
		private int _ProductId;
		
		private decimal _Price;
		
		private System.Nullable<System.DateTime> _CreateDate;
		
		private EntityRef<product_new> _product_new;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnUserIdChanging(int value);
    partial void OnUserIdChanged();
    partial void OnProductIdChanging(int value);
    partial void OnProductIdChanged();
    partial void OnPriceChanging(decimal value);
    partial void OnPriceChanged();
    partial void OnCreateDateChanging(System.Nullable<System.DateTime> value);
    partial void OnCreateDateChanged();
    #endregion
		
		public user_cart()
		{
			this._product_new = default(EntityRef<product_new>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserId", DbType="Int NOT NULL")]
		public int UserId
		{
			get
			{
				return this._UserId;
			}
			set
			{
				if ((this._UserId != value))
				{
					this.OnUserIdChanging(value);
					this.SendPropertyChanging();
					this._UserId = value;
					this.SendPropertyChanged("UserId");
					this.OnUserIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ProductId", DbType="Int NOT NULL")]
		public int ProductId
		{
			get
			{
				return this._ProductId;
			}
			set
			{
				if ((this._ProductId != value))
				{
					if (this._product_new.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnProductIdChanging(value);
					this.SendPropertyChanging();
					this._ProductId = value;
					this.SendPropertyChanged("ProductId");
					this.OnProductIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Price", DbType="SmallMoney NOT NULL")]
		public decimal Price
		{
			get
			{
				return this._Price;
			}
			set
			{
				if ((this._Price != value))
				{
					this.OnPriceChanging(value);
					this.SendPropertyChanging();
					this._Price = value;
					this.SendPropertyChanged("Price");
					this.OnPriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime")]
		public System.Nullable<System.DateTime> CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="product_new_user_cart", Storage="_product_new", ThisKey="ProductId", OtherKey="Id", IsForeignKey=true)]
		public product_new product_new
		{
			get
			{
				return this._product_new.Entity;
			}
			set
			{
				product_new previousValue = this._product_new.Entity;
				if (((previousValue != value) 
							|| (this._product_new.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._product_new.Entity = null;
						previousValue.user_carts.Remove(this);
					}
					this._product_new.Entity = value;
					if ((value != null))
					{
						value.user_carts.Add(this);
						this._ProductId = value.Id;
					}
					else
					{
						this._ProductId = default(int);
					}
					this.SendPropertyChanged("product_new");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
