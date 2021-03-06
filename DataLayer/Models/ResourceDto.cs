﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace DataLayer.Models
{
    public class ResourceDto  : INotifyPropertyChanged
    {
        private int resourceID;
        private int partID;
        private string resourceDescription;
        private string createdby;
        private DateTime createdDate;
        private int currentVersion;
        private byte[] data;
        private string src;
        private string fileSize;
        private bool isValid;
        private string extension;

        public string Extension
        {
            get { return extension; }
            set
            {
                extension = value;
                OnPropertyChange();
            }
        }

        public bool IsValid
        {
            get { return isValid; }
            set
            {
                isValid = value;
                OnPropertyChange();
            }

        }
        
        
        public string Src
        {
            get { return src; }
            set
            {
                src = value;
                OnPropertyChange();
            }
        }
        public string FileSize
        {
            get { return fileSize; }
            set
            {
                fileSize = value;
                OnPropertyChange();
            }
        }

        public byte[] Data
        {
            get { return data; }
            set
            {
                data = value;             
                OnPropertyChange();
            }
        }

        public DateTime CreatedDate
        {
            get { return createdDate; }
            set
            {
                createdDate = value;
                OnPropertyChange();
            }
        }


        public int PartID
        {
            get { return partID; }
            set
            {
                partID = value;
                OnPropertyChange();
            }
        }
        public int ResourceID
        {
            get { return resourceID; }
            set
            {
                resourceID = value;
                OnPropertyChange();
            }
        }
        public string ResourceDescription 
        {
            get { return resourceDescription; }
            set
            {
               resourceDescription = value ;
              
                OnPropertyChange();
            }
        }
        public string Createdby
        {
            get { return createdby; }
            set
            {
               createdby = value ;
               OnPropertyChange();
            } 
        }
        public int CurrentVersion
        {
            get {return currentVersion; }
            set
            {
               currentVersion = value ;
                OnPropertyChange();
            }
        }

    
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChange([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}





public class ResourceVersionDto : INotifyPropertyChanged
{
    private int resourceVersionID { get; set; }
    private int resourceID { get; set; }
    private int rVersion { get; set; }
    private string versionComment { get; set; }
    private Byte[] resource { get; set; }
    private string modifiedBy { get; set; }
    private DateTime modDate { get; set; }

    public int ResourceVersionID 
    {
        get { return resourceVersionID; }
        set
        {
           resourceVersionID = value ;
           OnPropertyChange();
        }
    }
    public int ResourceID
    {
        get { return resourceID; }
        set
        {
           resourceID = value ;
           OnPropertyChange();
        }
    }
    public int RVersion 
    {
        get { return rVersion; }
        set
        {
           rVersion = value ;
           OnPropertyChange();
        }
    }
    public string VersionComment 
    {
        get { return versionComment; }
        set
        {
          versionComment = value ;
            OnPropertyChange();
        } 
    }
    public Byte[] Resource 
    {
        get { return resource; }
        set
        {
           resource = value ;
           OnPropertyChange();
        } 
    }
    public string ModifiedBy
    {
        get { return modifiedBy; }
        set
        {
           modifiedBy = value ;
           OnPropertyChange();
        }
    }
    public DateTime ModDate
    {
        get { return modDate; }
        set
        {
           modDate = value ;
           OnPropertyChange();
        }
        
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected void OnPropertyChange([CallerMemberName] string name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }

}
