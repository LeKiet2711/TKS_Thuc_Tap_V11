using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TKS_Thuc_Tap_V11_Data_Access.Controller.Cache;
using TKS_Thuc_Tap_V11_Data_Access.Controller.DM;
using TKS_Thuc_Tap_V11_Data_Access.Utility;

namespace TKS_Thuc_Tap_V11_Data_Access.Entity.DM
{
    public class CDM_San_Pham
    {
        private long m_lngAuto_ID;
        private long m_lngLoai_San_Pham_ID;
        private long m_lngDon_Vi_Tinh_ID;
        private string m_Ma_San_Pham;
		private string m_Ten_San_Pham;
		private string m_Ghi_Chu;
		private int m_intdeleted;
        private DateTime? m_dtmCreated;
        private string m_strCreated_By;
        private string m_strCreated_By_Function;
        private DateTime? m_dtmLast_Updated;
        private string m_strLast_Updated_By;
        private string m_strLast_Updated_By_Function;

        private string m_Ten_LSP;
        private string m_Ten_Don_Vi_Tinh;


		public CDM_San_Pham()
        {
            ResetData();
        }

        public void ResetData()
        {
            m_lngAuto_ID = CConst.INT_VALUE_NULL;
            m_lngLoai_San_Pham_ID = CConst.INT_VALUE_NULL;
            m_lngDon_Vi_Tinh_ID = CConst.INT_VALUE_NULL;
            m_Ma_San_Pham = CConst.STR_VALUE_NULL;
            m_Ten_San_Pham = CConst.STR_VALUE_NULL;
            m_Ghi_Chu = CConst.STR_VALUE_NULL;
            m_intdeleted = CConst.INT_VALUE_NULL;
            m_dtmCreated = CConst.DTM_VALUE_NULL;
            m_strCreated_By = CConst.STR_VALUE_NULL;
            m_strCreated_By_Function = CConst.STR_VALUE_NULL;
            m_dtmLast_Updated = CConst.DTM_VALUE_NULL;
            m_strLast_Updated_By = CConst.STR_VALUE_NULL;
            m_strLast_Updated_By_Function = CConst.STR_VALUE_NULL;
        }

        public long Auto_ID
        {
            get
            {
                return m_lngAuto_ID;
            }
            set
            {
                m_lngAuto_ID = value;
            }
        }

        public long Loai_San_Pham_ID
        {
            get
            {
                return m_lngLoai_San_Pham_ID;
            }
            set
            {
                m_lngLoai_San_Pham_ID = value;
            }
        }

		//public string Ten_Loai_San_Pham
		//{
		//	get
		//	{
  //              if (m_lngLoai_San_Pham_ID == 0)
  //              {
  //                  return "";   
  //              }else return CCache_Loai_San_Pham.Get_Data_By_ID(m_lngLoai_San_Pham_ID).Ten_LSP;
		//	}
		//	set
		//	{
  //              if (m_lngLoai_San_Pham_ID == 0)
  //              {
		//			m_lngLoai_San_Pham_ID = 0;

  //              }else CCache_Loai_San_Pham.Get_Data_By_ID(m_lngLoai_San_Pham_ID).Ten_LSP = value;
		//	}
		//}

        public string Ten_LSP
        {
            get
            {
                return m_Ten_LSP;
			}
            set
            {
				m_Ten_LSP = value;
			}
        }

		public string Ten_Don_Vi_Tinh
		{
			get
			{
				return m_Ten_Don_Vi_Tinh;
			}
			set
			{
				m_Ten_Don_Vi_Tinh = value;
			}
		}

		public long Don_Vi_Tinh_ID
        {
            get
            {
                return m_lngDon_Vi_Tinh_ID;
            }
            set
            {
                m_lngDon_Vi_Tinh_ID = value;
            }
        }

		//public string Ten_Don_Vi_Tinh
		//{
		//	get
		//	{
  //              if (m_lngDon_Vi_Tinh_ID == 0)
  //              {
  //                  return "";
  //              }else return CCache_Don_Vi_Tinh.Get_Data_By_ID(m_lngDon_Vi_Tinh_ID).Ten_Don_Vi_Tinh;
		//	}
		//	set
		//	{
		//		if (m_lngDon_Vi_Tinh_ID == 0)
		//		{
		//			m_lngDon_Vi_Tinh_ID = 0;

		//		}
		//		else CCache_Don_Vi_Tinh.Get_Data_By_ID(m_lngDon_Vi_Tinh_ID).Ten_Don_Vi_Tinh = value;
		//	}
		//}

		public string Ma_San_Pham
		{
			get
			{
				return m_Ma_San_Pham;
			}
            set
			{
				m_Ma_San_Pham = value;
			}
		}

		public string Ten_San_Pham
        {
            get
            {
                return m_Ten_San_Pham;
            }
            set
            {
                m_Ten_San_Pham = value;
            }
        }

        public string Ghi_Chu
		{
			get
			{
				return m_Ghi_Chu;
			}
            set
			{
				m_Ghi_Chu = value;
			}
		}

        public int deleted
        {
            get
            {
                return m_intdeleted;
            }
            set
            {
                m_intdeleted = value;
            }
        }

        public DateTime? Created
        {
            get
            {
                return m_dtmCreated;
            }
            set
            {
                m_dtmCreated = value;
            }
        }

        public string Created_By
        {
            get
            {
                return m_strCreated_By;
            }
            set
            {
                m_strCreated_By = value.Trim();
            }
        }

        public string Created_By_Function
        {
            get
            {
                return m_strCreated_By_Function;
            }
            set
            {
                m_strCreated_By_Function = value.Trim();
            }
        }

        public DateTime? Last_Updated
        {
            get
            {
                return m_dtmLast_Updated;
            }
            set
            {
                m_dtmLast_Updated = value;
            }
        }

        public string Last_Updated_By
        {
            get
            {
                return m_strLast_Updated_By;
            }
            set
            {
                m_strLast_Updated_By = value.Trim();
            }
        }

        public string Last_Updated_By_Function
        {
            get
            {
                return m_strLast_Updated_By_Function;
            }
            set
            {
                m_strLast_Updated_By_Function = value.Trim();
            }
        }

    }
}
