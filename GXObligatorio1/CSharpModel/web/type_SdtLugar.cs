/*
               File: type_SdtLugar
        Description: Lugar
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:24.19
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using System.Web.Services.Protocols;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "Lugar" )]
   [XmlType(TypeName =  "Lugar" , Namespace = "GXObligatorio1" )]
   [Serializable]
   public class SdtLugar : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtLugar( )
      {
      }

      public SdtLugar( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( short AV8LugarId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV8LugarId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"LugarId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Lugar");
         metadata.Set("BT", "Lugar");
         metadata.Set("PK", "[ \"LugarId\" ]");
         metadata.Set("PKAssigned", "[ \"LugarId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"PaisId\",\"CiudadId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Lugarfoto_gxi");
         state.Add("gxTpr_Paisbandera_gxi");
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Lugarid_Z");
         state.Add("gxTpr_Lugarnombre_Z");
         state.Add("gxTpr_Paisid_Z");
         state.Add("gxTpr_Paisnombre_Z");
         state.Add("gxTpr_Ciudadid_Z");
         state.Add("gxTpr_Ciudadnombre_Z");
         state.Add("gxTpr_Cantespectaculoslugar_Z");
         state.Add("gxTpr_Lugarfoto_gxi_Z");
         state.Add("gxTpr_Paisbandera_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtLugar sdt ;
         sdt = (SdtLugar)(source);
         gxTv_SdtLugar_Lugarid = sdt.gxTv_SdtLugar_Lugarid ;
         gxTv_SdtLugar_Lugarnombre = sdt.gxTv_SdtLugar_Lugarnombre ;
         gxTv_SdtLugar_Lugarfoto = sdt.gxTv_SdtLugar_Lugarfoto ;
         gxTv_SdtLugar_Lugarfoto_gxi = sdt.gxTv_SdtLugar_Lugarfoto_gxi ;
         gxTv_SdtLugar_Paisid = sdt.gxTv_SdtLugar_Paisid ;
         gxTv_SdtLugar_Paisnombre = sdt.gxTv_SdtLugar_Paisnombre ;
         gxTv_SdtLugar_Paisbandera = sdt.gxTv_SdtLugar_Paisbandera ;
         gxTv_SdtLugar_Paisbandera_gxi = sdt.gxTv_SdtLugar_Paisbandera_gxi ;
         gxTv_SdtLugar_Ciudadid = sdt.gxTv_SdtLugar_Ciudadid ;
         gxTv_SdtLugar_Ciudadnombre = sdt.gxTv_SdtLugar_Ciudadnombre ;
         gxTv_SdtLugar_Cantespectaculoslugar = sdt.gxTv_SdtLugar_Cantespectaculoslugar ;
         gxTv_SdtLugar_Mode = sdt.gxTv_SdtLugar_Mode ;
         gxTv_SdtLugar_Initialized = sdt.gxTv_SdtLugar_Initialized ;
         gxTv_SdtLugar_Lugarid_Z = sdt.gxTv_SdtLugar_Lugarid_Z ;
         gxTv_SdtLugar_Lugarnombre_Z = sdt.gxTv_SdtLugar_Lugarnombre_Z ;
         gxTv_SdtLugar_Paisid_Z = sdt.gxTv_SdtLugar_Paisid_Z ;
         gxTv_SdtLugar_Paisnombre_Z = sdt.gxTv_SdtLugar_Paisnombre_Z ;
         gxTv_SdtLugar_Ciudadid_Z = sdt.gxTv_SdtLugar_Ciudadid_Z ;
         gxTv_SdtLugar_Ciudadnombre_Z = sdt.gxTv_SdtLugar_Ciudadnombre_Z ;
         gxTv_SdtLugar_Cantespectaculoslugar_Z = sdt.gxTv_SdtLugar_Cantespectaculoslugar_Z ;
         gxTv_SdtLugar_Lugarfoto_gxi_Z = sdt.gxTv_SdtLugar_Lugarfoto_gxi_Z ;
         gxTv_SdtLugar_Paisbandera_gxi_Z = sdt.gxTv_SdtLugar_Paisbandera_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         ToJSON( includeState, true) ;
         return  ;
      }

      public override void ToJSON( bool includeState ,
                                   bool includeNonInitialized )
      {
         AddObjectProperty("LugarId", gxTv_SdtLugar_Lugarid, false, includeNonInitialized);
         AddObjectProperty("LugarNombre", gxTv_SdtLugar_Lugarnombre, false, includeNonInitialized);
         AddObjectProperty("LugarFoto", gxTv_SdtLugar_Lugarfoto, false, includeNonInitialized);
         AddObjectProperty("PaisId", gxTv_SdtLugar_Paisid, false, includeNonInitialized);
         AddObjectProperty("PaisNombre", gxTv_SdtLugar_Paisnombre, false, includeNonInitialized);
         AddObjectProperty("PaisBandera", gxTv_SdtLugar_Paisbandera, false, includeNonInitialized);
         AddObjectProperty("CiudadId", gxTv_SdtLugar_Ciudadid, false, includeNonInitialized);
         AddObjectProperty("CiudadNombre", gxTv_SdtLugar_Ciudadnombre, false, includeNonInitialized);
         AddObjectProperty("CantEspectaculosLugar", gxTv_SdtLugar_Cantespectaculoslugar, false, includeNonInitialized);
         if ( includeState )
         {
            AddObjectProperty("LugarFoto_GXI", gxTv_SdtLugar_Lugarfoto_gxi, false, includeNonInitialized);
            AddObjectProperty("PaisBandera_GXI", gxTv_SdtLugar_Paisbandera_gxi, false, includeNonInitialized);
            AddObjectProperty("Mode", gxTv_SdtLugar_Mode, false, includeNonInitialized);
            AddObjectProperty("Initialized", gxTv_SdtLugar_Initialized, false, includeNonInitialized);
            AddObjectProperty("LugarId_Z", gxTv_SdtLugar_Lugarid_Z, false, includeNonInitialized);
            AddObjectProperty("LugarNombre_Z", gxTv_SdtLugar_Lugarnombre_Z, false, includeNonInitialized);
            AddObjectProperty("PaisId_Z", gxTv_SdtLugar_Paisid_Z, false, includeNonInitialized);
            AddObjectProperty("PaisNombre_Z", gxTv_SdtLugar_Paisnombre_Z, false, includeNonInitialized);
            AddObjectProperty("CiudadId_Z", gxTv_SdtLugar_Ciudadid_Z, false, includeNonInitialized);
            AddObjectProperty("CiudadNombre_Z", gxTv_SdtLugar_Ciudadnombre_Z, false, includeNonInitialized);
            AddObjectProperty("CantEspectaculosLugar_Z", gxTv_SdtLugar_Cantespectaculoslugar_Z, false, includeNonInitialized);
            AddObjectProperty("LugarFoto_GXI_Z", gxTv_SdtLugar_Lugarfoto_gxi_Z, false, includeNonInitialized);
            AddObjectProperty("PaisBandera_GXI_Z", gxTv_SdtLugar_Paisbandera_gxi_Z, false, includeNonInitialized);
         }
         return  ;
      }

      public void UpdateDirties( SdtLugar sdt )
      {
         if ( sdt.IsDirty("LugarId") )
         {
            gxTv_SdtLugar_Lugarid = sdt.gxTv_SdtLugar_Lugarid ;
         }
         if ( sdt.IsDirty("LugarNombre") )
         {
            gxTv_SdtLugar_Lugarnombre = sdt.gxTv_SdtLugar_Lugarnombre ;
         }
         if ( sdt.IsDirty("LugarFoto") )
         {
            gxTv_SdtLugar_Lugarfoto = sdt.gxTv_SdtLugar_Lugarfoto ;
         }
         if ( sdt.IsDirty("LugarFoto") )
         {
            gxTv_SdtLugar_Lugarfoto_gxi = sdt.gxTv_SdtLugar_Lugarfoto_gxi ;
         }
         if ( sdt.IsDirty("PaisId") )
         {
            gxTv_SdtLugar_Paisid = sdt.gxTv_SdtLugar_Paisid ;
         }
         if ( sdt.IsDirty("PaisNombre") )
         {
            gxTv_SdtLugar_Paisnombre = sdt.gxTv_SdtLugar_Paisnombre ;
         }
         if ( sdt.IsDirty("PaisBandera") )
         {
            gxTv_SdtLugar_Paisbandera = sdt.gxTv_SdtLugar_Paisbandera ;
         }
         if ( sdt.IsDirty("PaisBandera") )
         {
            gxTv_SdtLugar_Paisbandera_gxi = sdt.gxTv_SdtLugar_Paisbandera_gxi ;
         }
         if ( sdt.IsDirty("CiudadId") )
         {
            gxTv_SdtLugar_Ciudadid = sdt.gxTv_SdtLugar_Ciudadid ;
         }
         if ( sdt.IsDirty("CiudadNombre") )
         {
            gxTv_SdtLugar_Ciudadnombre = sdt.gxTv_SdtLugar_Ciudadnombre ;
         }
         if ( sdt.IsDirty("CantEspectaculosLugar") )
         {
            gxTv_SdtLugar_Cantespectaculoslugar = sdt.gxTv_SdtLugar_Cantespectaculoslugar ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "LugarId" )]
      [  XmlElement( ElementName = "LugarId"   )]
      public short gxTpr_Lugarid
      {
         get {
            return gxTv_SdtLugar_Lugarid ;
         }

         set {
            if ( gxTv_SdtLugar_Lugarid != value )
            {
               gxTv_SdtLugar_Mode = "INS";
               this.gxTv_SdtLugar_Lugarid_Z_SetNull( );
               this.gxTv_SdtLugar_Lugarnombre_Z_SetNull( );
               this.gxTv_SdtLugar_Paisid_Z_SetNull( );
               this.gxTv_SdtLugar_Paisnombre_Z_SetNull( );
               this.gxTv_SdtLugar_Ciudadid_Z_SetNull( );
               this.gxTv_SdtLugar_Ciudadnombre_Z_SetNull( );
               this.gxTv_SdtLugar_Cantespectaculoslugar_Z_SetNull( );
               this.gxTv_SdtLugar_Lugarfoto_gxi_Z_SetNull( );
               this.gxTv_SdtLugar_Paisbandera_gxi_Z_SetNull( );
            }
            gxTv_SdtLugar_Lugarid = value;
            SetDirty("Lugarid");
         }

      }

      [  SoapElement( ElementName = "LugarNombre" )]
      [  XmlElement( ElementName = "LugarNombre"   )]
      public String gxTpr_Lugarnombre
      {
         get {
            return gxTv_SdtLugar_Lugarnombre ;
         }

         set {
            gxTv_SdtLugar_Lugarnombre = value;
            SetDirty("Lugarnombre");
         }

      }

      [  SoapElement( ElementName = "LugarFoto" )]
      [  XmlElement( ElementName = "LugarFoto"   )]
      [GxUpload()]
      public String gxTpr_Lugarfoto
      {
         get {
            return gxTv_SdtLugar_Lugarfoto ;
         }

         set {
            gxTv_SdtLugar_Lugarfoto = value;
            SetDirty("Lugarfoto");
         }

      }

      [  SoapElement( ElementName = "LugarFoto_GXI" )]
      [  XmlElement( ElementName = "LugarFoto_GXI"   )]
      public String gxTpr_Lugarfoto_gxi
      {
         get {
            return gxTv_SdtLugar_Lugarfoto_gxi ;
         }

         set {
            gxTv_SdtLugar_Lugarfoto_gxi = value;
            SetDirty("Lugarfoto_gxi");
         }

      }

      [  SoapElement( ElementName = "PaisId" )]
      [  XmlElement( ElementName = "PaisId"   )]
      public short gxTpr_Paisid
      {
         get {
            return gxTv_SdtLugar_Paisid ;
         }

         set {
            gxTv_SdtLugar_Paisid = value;
            SetDirty("Paisid");
         }

      }

      [  SoapElement( ElementName = "PaisNombre" )]
      [  XmlElement( ElementName = "PaisNombre"   )]
      public String gxTpr_Paisnombre
      {
         get {
            return gxTv_SdtLugar_Paisnombre ;
         }

         set {
            gxTv_SdtLugar_Paisnombre = value;
            SetDirty("Paisnombre");
         }

      }

      [  SoapElement( ElementName = "PaisBandera" )]
      [  XmlElement( ElementName = "PaisBandera"   )]
      [GxUpload()]
      public String gxTpr_Paisbandera
      {
         get {
            return gxTv_SdtLugar_Paisbandera ;
         }

         set {
            gxTv_SdtLugar_Paisbandera = value;
            SetDirty("Paisbandera");
         }

      }

      [  SoapElement( ElementName = "PaisBandera_GXI" )]
      [  XmlElement( ElementName = "PaisBandera_GXI"   )]
      public String gxTpr_Paisbandera_gxi
      {
         get {
            return gxTv_SdtLugar_Paisbandera_gxi ;
         }

         set {
            gxTv_SdtLugar_Paisbandera_gxi = value;
            SetDirty("Paisbandera_gxi");
         }

      }

      [  SoapElement( ElementName = "CiudadId" )]
      [  XmlElement( ElementName = "CiudadId"   )]
      public short gxTpr_Ciudadid
      {
         get {
            return gxTv_SdtLugar_Ciudadid ;
         }

         set {
            gxTv_SdtLugar_Ciudadid = value;
            SetDirty("Ciudadid");
         }

      }

      [  SoapElement( ElementName = "CiudadNombre" )]
      [  XmlElement( ElementName = "CiudadNombre"   )]
      public String gxTpr_Ciudadnombre
      {
         get {
            return gxTv_SdtLugar_Ciudadnombre ;
         }

         set {
            gxTv_SdtLugar_Ciudadnombre = value;
            SetDirty("Ciudadnombre");
         }

      }

      [  SoapElement( ElementName = "CantEspectaculosLugar" )]
      [  XmlElement( ElementName = "CantEspectaculosLugar"   )]
      public short gxTpr_Cantespectaculoslugar
      {
         get {
            return gxTv_SdtLugar_Cantespectaculoslugar ;
         }

         set {
            gxTv_SdtLugar_Cantespectaculoslugar = value;
            SetDirty("Cantespectaculoslugar");
         }

      }

      public void gxTv_SdtLugar_Cantespectaculoslugar_SetNull( )
      {
         gxTv_SdtLugar_Cantespectaculoslugar = 0;
         return  ;
      }

      public bool gxTv_SdtLugar_Cantespectaculoslugar_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtLugar_Mode ;
         }

         set {
            gxTv_SdtLugar_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtLugar_Mode_SetNull( )
      {
         gxTv_SdtLugar_Mode = "";
         return  ;
      }

      public bool gxTv_SdtLugar_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtLugar_Initialized ;
         }

         set {
            gxTv_SdtLugar_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtLugar_Initialized_SetNull( )
      {
         gxTv_SdtLugar_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtLugar_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LugarId_Z" )]
      [  XmlElement( ElementName = "LugarId_Z"   )]
      public short gxTpr_Lugarid_Z
      {
         get {
            return gxTv_SdtLugar_Lugarid_Z ;
         }

         set {
            gxTv_SdtLugar_Lugarid_Z = value;
            SetDirty("Lugarid_Z");
         }

      }

      public void gxTv_SdtLugar_Lugarid_Z_SetNull( )
      {
         gxTv_SdtLugar_Lugarid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtLugar_Lugarid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LugarNombre_Z" )]
      [  XmlElement( ElementName = "LugarNombre_Z"   )]
      public String gxTpr_Lugarnombre_Z
      {
         get {
            return gxTv_SdtLugar_Lugarnombre_Z ;
         }

         set {
            gxTv_SdtLugar_Lugarnombre_Z = value;
            SetDirty("Lugarnombre_Z");
         }

      }

      public void gxTv_SdtLugar_Lugarnombre_Z_SetNull( )
      {
         gxTv_SdtLugar_Lugarnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtLugar_Lugarnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PaisId_Z" )]
      [  XmlElement( ElementName = "PaisId_Z"   )]
      public short gxTpr_Paisid_Z
      {
         get {
            return gxTv_SdtLugar_Paisid_Z ;
         }

         set {
            gxTv_SdtLugar_Paisid_Z = value;
            SetDirty("Paisid_Z");
         }

      }

      public void gxTv_SdtLugar_Paisid_Z_SetNull( )
      {
         gxTv_SdtLugar_Paisid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtLugar_Paisid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PaisNombre_Z" )]
      [  XmlElement( ElementName = "PaisNombre_Z"   )]
      public String gxTpr_Paisnombre_Z
      {
         get {
            return gxTv_SdtLugar_Paisnombre_Z ;
         }

         set {
            gxTv_SdtLugar_Paisnombre_Z = value;
            SetDirty("Paisnombre_Z");
         }

      }

      public void gxTv_SdtLugar_Paisnombre_Z_SetNull( )
      {
         gxTv_SdtLugar_Paisnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtLugar_Paisnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CiudadId_Z" )]
      [  XmlElement( ElementName = "CiudadId_Z"   )]
      public short gxTpr_Ciudadid_Z
      {
         get {
            return gxTv_SdtLugar_Ciudadid_Z ;
         }

         set {
            gxTv_SdtLugar_Ciudadid_Z = value;
            SetDirty("Ciudadid_Z");
         }

      }

      public void gxTv_SdtLugar_Ciudadid_Z_SetNull( )
      {
         gxTv_SdtLugar_Ciudadid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtLugar_Ciudadid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CiudadNombre_Z" )]
      [  XmlElement( ElementName = "CiudadNombre_Z"   )]
      public String gxTpr_Ciudadnombre_Z
      {
         get {
            return gxTv_SdtLugar_Ciudadnombre_Z ;
         }

         set {
            gxTv_SdtLugar_Ciudadnombre_Z = value;
            SetDirty("Ciudadnombre_Z");
         }

      }

      public void gxTv_SdtLugar_Ciudadnombre_Z_SetNull( )
      {
         gxTv_SdtLugar_Ciudadnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtLugar_Ciudadnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CantEspectaculosLugar_Z" )]
      [  XmlElement( ElementName = "CantEspectaculosLugar_Z"   )]
      public short gxTpr_Cantespectaculoslugar_Z
      {
         get {
            return gxTv_SdtLugar_Cantespectaculoslugar_Z ;
         }

         set {
            gxTv_SdtLugar_Cantespectaculoslugar_Z = value;
            SetDirty("Cantespectaculoslugar_Z");
         }

      }

      public void gxTv_SdtLugar_Cantespectaculoslugar_Z_SetNull( )
      {
         gxTv_SdtLugar_Cantespectaculoslugar_Z = 0;
         return  ;
      }

      public bool gxTv_SdtLugar_Cantespectaculoslugar_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "LugarFoto_GXI_Z" )]
      [  XmlElement( ElementName = "LugarFoto_GXI_Z"   )]
      public String gxTpr_Lugarfoto_gxi_Z
      {
         get {
            return gxTv_SdtLugar_Lugarfoto_gxi_Z ;
         }

         set {
            gxTv_SdtLugar_Lugarfoto_gxi_Z = value;
            SetDirty("Lugarfoto_gxi_Z");
         }

      }

      public void gxTv_SdtLugar_Lugarfoto_gxi_Z_SetNull( )
      {
         gxTv_SdtLugar_Lugarfoto_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtLugar_Lugarfoto_gxi_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PaisBandera_GXI_Z" )]
      [  XmlElement( ElementName = "PaisBandera_GXI_Z"   )]
      public String gxTpr_Paisbandera_gxi_Z
      {
         get {
            return gxTv_SdtLugar_Paisbandera_gxi_Z ;
         }

         set {
            gxTv_SdtLugar_Paisbandera_gxi_Z = value;
            SetDirty("Paisbandera_gxi_Z");
         }

      }

      public void gxTv_SdtLugar_Paisbandera_gxi_Z_SetNull( )
      {
         gxTv_SdtLugar_Paisbandera_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtLugar_Paisbandera_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtLugar_Lugarid = 1;
         gxTv_SdtLugar_Lugarnombre = "";
         gxTv_SdtLugar_Lugarfoto = "";
         gxTv_SdtLugar_Lugarfoto_gxi = "";
         gxTv_SdtLugar_Paisid = 1;
         gxTv_SdtLugar_Paisnombre = "";
         gxTv_SdtLugar_Paisbandera = "";
         gxTv_SdtLugar_Paisbandera_gxi = "";
         gxTv_SdtLugar_Ciudadnombre = "";
         gxTv_SdtLugar_Mode = "";
         gxTv_SdtLugar_Lugarnombre_Z = "";
         gxTv_SdtLugar_Paisnombre_Z = "";
         gxTv_SdtLugar_Ciudadnombre_Z = "";
         gxTv_SdtLugar_Lugarfoto_gxi_Z = "";
         gxTv_SdtLugar_Paisbandera_gxi_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "lugar", "GeneXus.Programs.lugar_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtLugar_Lugarid ;
      private short gxTv_SdtLugar_Paisid ;
      private short gxTv_SdtLugar_Ciudadid ;
      private short gxTv_SdtLugar_Cantespectaculoslugar ;
      private short gxTv_SdtLugar_Initialized ;
      private short gxTv_SdtLugar_Lugarid_Z ;
      private short gxTv_SdtLugar_Paisid_Z ;
      private short gxTv_SdtLugar_Ciudadid_Z ;
      private short gxTv_SdtLugar_Cantespectaculoslugar_Z ;
      private String gxTv_SdtLugar_Lugarnombre ;
      private String gxTv_SdtLugar_Paisnombre ;
      private String gxTv_SdtLugar_Ciudadnombre ;
      private String gxTv_SdtLugar_Mode ;
      private String gxTv_SdtLugar_Lugarnombre_Z ;
      private String gxTv_SdtLugar_Paisnombre_Z ;
      private String gxTv_SdtLugar_Ciudadnombre_Z ;
      private String gxTv_SdtLugar_Lugarfoto_gxi ;
      private String gxTv_SdtLugar_Paisbandera_gxi ;
      private String gxTv_SdtLugar_Lugarfoto_gxi_Z ;
      private String gxTv_SdtLugar_Paisbandera_gxi_Z ;
      private String gxTv_SdtLugar_Lugarfoto ;
      private String gxTv_SdtLugar_Paisbandera ;
   }

   [DataContract(Name = @"Lugar", Namespace = "GXObligatorio1")]
   public class SdtLugar_RESTInterface : GxGenericCollectionItem<SdtLugar>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtLugar_RESTInterface( ) : base()
      {
      }

      public SdtLugar_RESTInterface( SdtLugar psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "LugarId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Lugarid
      {
         get {
            return sdt.gxTpr_Lugarid ;
         }

         set {
            sdt.gxTpr_Lugarid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "LugarNombre" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Lugarnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Lugarnombre) ;
         }

         set {
            sdt.gxTpr_Lugarnombre = value;
         }

      }

      [DataMember( Name = "LugarFoto" , Order = 2 )]
      [GxUpload()]
      public String gxTpr_Lugarfoto
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Lugarfoto)) ? PathUtil.RelativeURL( sdt.gxTpr_Lugarfoto) : StringUtil.RTrim( sdt.gxTpr_Lugarfoto_gxi)) ;
         }

         set {
            sdt.gxTpr_Lugarfoto = value;
         }

      }

      [DataMember( Name = "PaisId" , Order = 3 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Paisid
      {
         get {
            return sdt.gxTpr_Paisid ;
         }

         set {
            sdt.gxTpr_Paisid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "PaisNombre" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Paisnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Paisnombre) ;
         }

         set {
            sdt.gxTpr_Paisnombre = value;
         }

      }

      [DataMember( Name = "PaisBandera" , Order = 5 )]
      [GxUpload()]
      public String gxTpr_Paisbandera
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Paisbandera)) ? PathUtil.RelativeURL( sdt.gxTpr_Paisbandera) : StringUtil.RTrim( sdt.gxTpr_Paisbandera_gxi)) ;
         }

         set {
            sdt.gxTpr_Paisbandera = value;
         }

      }

      [DataMember( Name = "CiudadId" , Order = 6 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Ciudadid
      {
         get {
            return sdt.gxTpr_Ciudadid ;
         }

         set {
            sdt.gxTpr_Ciudadid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "CiudadNombre" , Order = 7 )]
      [GxSeudo()]
      public String gxTpr_Ciudadnombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Ciudadnombre) ;
         }

         set {
            sdt.gxTpr_Ciudadnombre = value;
         }

      }

      [DataMember( Name = "CantEspectaculosLugar" , Order = 8 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Cantespectaculoslugar
      {
         get {
            return sdt.gxTpr_Cantespectaculoslugar ;
         }

         set {
            sdt.gxTpr_Cantespectaculoslugar = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtLugar sdt
      {
         get {
            return (SdtLugar)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtLugar() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 9 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

}
