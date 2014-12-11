﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WTFClassLibrary
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ExtraSytelineTables")]
	public partial class SL8DbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSetting(Setting instance);
    partial void UpdateSetting(Setting instance);
    partial void DeleteSetting(Setting instance);
    partial void InsertShipCarrier(ShipCarrier instance);
    partial void UpdateShipCarrier(ShipCarrier instance);
    partial void DeleteShipCarrier(ShipCarrier instance);
    partial void InsertShipClassification(ShipClassification instance);
    partial void UpdateShipClassification(ShipClassification instance);
    partial void DeleteShipClassification(ShipClassification instance);
    partial void InsertCustomerLabel(CustomerLabel instance);
    partial void UpdateCustomerLabel(CustomerLabel instance);
    partial void DeleteCustomerLabel(CustomerLabel instance);
    partial void InsertPurchasedItem(PurchasedItem instance);
    partial void UpdatePurchasedItem(PurchasedItem instance);
    partial void DeletePurchasedItem(PurchasedItem instance);
    #endregion
		
		public SL8DbDataContext() : 
				base(global::WTFClassLibrary.Properties.Settings.Default.ExtraSytelineTablesConnectionString1, mappingSource)
		{
			OnCreated();
		}
		
		public SL8DbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SL8DbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SL8DbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public SL8DbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Setting> Settings
		{
			get
			{
				return this.GetTable<Setting>();
			}
		}
		
		public System.Data.Linq.Table<ShipCarrier> ShipCarriers
		{
			get
			{
				return this.GetTable<ShipCarrier>();
			}
		}
		
		public System.Data.Linq.Table<ShipClassification> ShipClassifications
		{
			get
			{
				return this.GetTable<ShipClassification>();
			}
		}
		
		public System.Data.Linq.Table<CustomerLabel> CustomerLabels
		{
			get
			{
				return this.GetTable<CustomerLabel>();
			}
		}
		
		public System.Data.Linq.Table<PurchasedItem> PurchasedItems
		{
			get
			{
				return this.GetTable<PurchasedItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Settings")]
	public partial class Setting : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _SettingsID;
		
		private string _KeyName;
		
		private string _Setting1;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSettingsIDChanging(int value);
    partial void OnSettingsIDChanged();
    partial void OnKeyNameChanging(string value);
    partial void OnKeyNameChanged();
    partial void OnSetting1Changing(string value);
    partial void OnSetting1Changed();
    #endregion
		
		public Setting()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SettingsID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int SettingsID
		{
			get
			{
				return this._SettingsID;
			}
			set
			{
				if ((this._SettingsID != value))
				{
					this.OnSettingsIDChanging(value);
					this.SendPropertyChanging();
					this._SettingsID = value;
					this.SendPropertyChanged("SettingsID");
					this.OnSettingsIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KeyName", DbType="VarChar(64) NOT NULL", CanBeNull=false)]
		public string KeyName
		{
			get
			{
				return this._KeyName;
			}
			set
			{
				if ((this._KeyName != value))
				{
					this.OnKeyNameChanging(value);
					this.SendPropertyChanging();
					this._KeyName = value;
					this.SendPropertyChanged("KeyName");
					this.OnKeyNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="Setting", Storage="_Setting1", DbType="VarChar(256) NOT NULL", CanBeNull=false)]
		public string Setting1
		{
			get
			{
				return this._Setting1;
			}
			set
			{
				if ((this._Setting1 != value))
				{
					this.OnSetting1Changing(value);
					this.SendPropertyChanging();
					this._Setting1 = value;
					this.SendPropertyChanged("Setting1");
					this.OnSetting1Changed();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ShipCarriers")]
	public partial class ShipCarrier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ShipCarriersID;
		
		private string _CarrierDesc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnShipCarriersIDChanging(int value);
    partial void OnShipCarriersIDChanged();
    partial void OnCarrierDescChanging(string value);
    partial void OnCarrierDescChanged();
    #endregion
		
		public ShipCarrier()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ShipCarriersID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ShipCarriersID
		{
			get
			{
				return this._ShipCarriersID;
			}
			set
			{
				if ((this._ShipCarriersID != value))
				{
					this.OnShipCarriersIDChanging(value);
					this.SendPropertyChanging();
					this._ShipCarriersID = value;
					this.SendPropertyChanged("ShipCarriersID");
					this.OnShipCarriersIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CarrierDesc", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string CarrierDesc
		{
			get
			{
				return this._CarrierDesc;
			}
			set
			{
				if ((this._CarrierDesc != value))
				{
					this.OnCarrierDescChanging(value);
					this.SendPropertyChanging();
					this._CarrierDesc = value;
					this.SendPropertyChanged("CarrierDesc");
					this.OnCarrierDescChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ShipClassification")]
	public partial class ShipClassification : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ItemRef;
		
		private string _ItemDesc;
		
		private string _ItemNo;
		
		private string _Class;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemRefChanging(int value);
    partial void OnItemRefChanged();
    partial void OnItemDescChanging(string value);
    partial void OnItemDescChanged();
    partial void OnItemNoChanging(string value);
    partial void OnItemNoChanged();
    partial void OnClassChanging(string value);
    partial void OnClassChanged();
    #endregion
		
		public ShipClassification()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemRef", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ItemRef
		{
			get
			{
				return this._ItemRef;
			}
			set
			{
				if ((this._ItemRef != value))
				{
					this.OnItemRefChanging(value);
					this.SendPropertyChanging();
					this._ItemRef = value;
					this.SendPropertyChanged("ItemRef");
					this.OnItemRefChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemDesc", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
		public string ItemDesc
		{
			get
			{
				return this._ItemDesc;
			}
			set
			{
				if ((this._ItemDesc != value))
				{
					this.OnItemDescChanging(value);
					this.SendPropertyChanging();
					this._ItemDesc = value;
					this.SendPropertyChanged("ItemDesc");
					this.OnItemDescChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemNo", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string ItemNo
		{
			get
			{
				return this._ItemNo;
			}
			set
			{
				if ((this._ItemNo != value))
				{
					this.OnItemNoChanging(value);
					this.SendPropertyChanging();
					this._ItemNo = value;
					this.SendPropertyChanged("ItemNo");
					this.OnItemNoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Class", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string Class
		{
			get
			{
				return this._Class;
			}
			set
			{
				if ((this._Class != value))
				{
					this.OnClassChanging(value);
					this.SendPropertyChanging();
					this._Class = value;
					this.SendPropertyChanged("Class");
					this.OnClassChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CustomerLabel")]
	public partial class CustomerLabel : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _CustomerLabelID;
		
		private System.Nullable<int> _cust_num;
		
		private string _LabelFile;
		
		private string _description;
		
		private System.Nullable<int> _AddrLineCt;
		
		private int _Sequence;
		
		private string _SupplierNumber;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustomerLabelIDChanging(int value);
    partial void OnCustomerLabelIDChanged();
    partial void Oncust_numChanging(System.Nullable<int> value);
    partial void Oncust_numChanged();
    partial void OnLabelFileChanging(string value);
    partial void OnLabelFileChanged();
    partial void OndescriptionChanging(string value);
    partial void OndescriptionChanged();
    partial void OnAddrLineCtChanging(System.Nullable<int> value);
    partial void OnAddrLineCtChanged();
    partial void OnSequenceChanging(int value);
    partial void OnSequenceChanged();
    partial void OnSupplierNumberChanging(string value);
    partial void OnSupplierNumberChanged();
    #endregion
		
		public CustomerLabel()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustomerLabelID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int CustomerLabelID
		{
			get
			{
				return this._CustomerLabelID;
			}
			set
			{
				if ((this._CustomerLabelID != value))
				{
					this.OnCustomerLabelIDChanging(value);
					this.SendPropertyChanging();
					this._CustomerLabelID = value;
					this.SendPropertyChanged("CustomerLabelID");
					this.OnCustomerLabelIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[cust-num]", Storage="_cust_num", DbType="Int")]
		public System.Nullable<int> cust_num
		{
			get
			{
				return this._cust_num;
			}
			set
			{
				if ((this._cust_num != value))
				{
					this.Oncust_numChanging(value);
					this.SendPropertyChanging();
					this._cust_num = value;
					this.SendPropertyChanged("cust_num");
					this.Oncust_numChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LabelFile", DbType="NVarChar(64)")]
		public string LabelFile
		{
			get
			{
				return this._LabelFile;
			}
			set
			{
				if ((this._LabelFile != value))
				{
					this.OnLabelFileChanging(value);
					this.SendPropertyChanging();
					this._LabelFile = value;
					this.SendPropertyChanged("LabelFile");
					this.OnLabelFileChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_description", DbType="NVarChar(255)")]
		public string description
		{
			get
			{
				return this._description;
			}
			set
			{
				if ((this._description != value))
				{
					this.OndescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("description");
					this.OndescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AddrLineCt", DbType="Int")]
		public System.Nullable<int> AddrLineCt
		{
			get
			{
				return this._AddrLineCt;
			}
			set
			{
				if ((this._AddrLineCt != value))
				{
					this.OnAddrLineCtChanging(value);
					this.SendPropertyChanging();
					this._AddrLineCt = value;
					this.SendPropertyChanged("AddrLineCt");
					this.OnAddrLineCtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sequence", DbType="Int NOT NULL")]
		public int Sequence
		{
			get
			{
				return this._Sequence;
			}
			set
			{
				if ((this._Sequence != value))
				{
					this.OnSequenceChanging(value);
					this.SendPropertyChanging();
					this._Sequence = value;
					this.SendPropertyChanged("Sequence");
					this.OnSequenceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SupplierNumber", DbType="VarChar(16)")]
		public string SupplierNumber
		{
			get
			{
				return this._SupplierNumber;
			}
			set
			{
				if ((this._SupplierNumber != value))
				{
					this.OnSupplierNumberChanging(value);
					this.SendPropertyChanging();
					this._SupplierNumber = value;
					this.SendPropertyChanged("SupplierNumber");
					this.OnSupplierNumberChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.PurchasedItems")]
	public partial class PurchasedItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _ItemID;
		
		private string _Description;
		
		private string _UnitOfMeasure;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnItemIDChanging(string value);
    partial void OnItemIDChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnUnitOfMeasureChanging(string value);
    partial void OnUnitOfMeasureChanged();
    #endregion
		
		public PurchasedItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ItemID", DbType="NVarChar(30) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string ItemID
		{
			get
			{
				return this._ItemID;
			}
			set
			{
				if ((this._ItemID != value))
				{
					this.OnItemIDChanging(value);
					this.SendPropertyChanging();
					this._ItemID = value;
					this.SendPropertyChanged("ItemID");
					this.OnItemIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(50)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UnitOfMeasure", DbType="NVarChar(10)")]
		public string UnitOfMeasure
		{
			get
			{
				return this._UnitOfMeasure;
			}
			set
			{
				if ((this._UnitOfMeasure != value))
				{
					this.OnUnitOfMeasureChanging(value);
					this.SendPropertyChanging();
					this._UnitOfMeasure = value;
					this.SendPropertyChanged("UnitOfMeasure");
					this.OnUnitOfMeasureChanged();
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
