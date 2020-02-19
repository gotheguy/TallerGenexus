/*
               File: type_SdtPais_Ciudad
        Description: Pais
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/18/2020 22:53:12.69
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
   [XmlRoot(ElementName = "Pais.Ciudad" )]
   [XmlType(TypeName =  "Pais.Ciudad" , Namespace = "GXObligatorio1" )]
   [Serializable]
   public class SdtPais_Ciudad : GxSilentTrnSdt, IGxSilentTrnGridItem
   {
      public SdtPais_Ciudad( )
      {
      }

      public SdtPais_Ciudad( IGxContext context )
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

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"CiudadId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Ciudad");
         metadata.Set("BT", "PaisCiudad");
         metadata.Set("PK", "[ \"CiudadId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"PaisId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Modified");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Ciudadid_Z");
         state.Add("gxTpr_Ciudadnombre_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtPais_Ciudad sdt ;
         sdt = (SdtPais_Ciudad)(source);
         gxTv_SdtPais_Ciudad_Ciudadid = sdt.gxTv_SdtPais_Ciudad_Ciudadid ;
         gxTv_SdtPais_Ciudad_Ciudadnombre = sdt.gxTv_SdtPais_Ciudad_Ciudadnombre ;
         gxTv_SdtPais_Ciudad_Mode = sdt.gxTv_SdtPais_Ciudad_Mode ;
         gxTv_SdtPais_Ciudad_Modified = sdt.gxTv_SdtPais_Ciudad_Modified ;
         gxTv_SdtPais_Ciudad_Initialized = sdt.gxTv_SdtPais_Ciudad_Initialized ;
         gxTv_SdtPais_Ciudad_Ciudadid_Z = sdt.gxTv_SdtPais_Ciudad_Ciudadid_Z ;
         gxTv_SdtPais_Ciudad_Ciudadnombre_Z = sdt.gxTv_SdtPais_Ciudad_Ciudadnombre_Z ;
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
         AddObjectProperty("CiudadId", gxTv_SdtPais_Ciudad_Ciudadid, false, includeNonInitialized);
         AddObjectProperty("CiudadNombre", gxTv_SdtPais_Ciudad_Ciudadnombre, false, includeNonInitialized);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtPais_Ciudad_Mode, false, includeNonInitialized);
            AddObjectProperty("Modified", gxTv_SdtPais_Ciudad_Modified, false, includeNonInitialized);
            AddObjectProperty("Initialized", gxTv_SdtPais_Ciudad_Initialized, false, includeNonInitialized);
            AddObjectProperty("CiudadId_Z", gxTv_SdtPais_Ciudad_Ciudadid_Z, false, includeNonInitialized);
            AddObjectProperty("CiudadNombre_Z", gxTv_SdtPais_Ciudad_Ciudadnombre_Z, false, includeNonInitialized);
         }
         return  ;
      }

      public void UpdateDirties( SdtPais_Ciudad sdt )
      {
         if ( sdt.IsDirty("CiudadId") )
         {
            gxTv_SdtPais_Ciudad_Ciudadid = sdt.gxTv_SdtPais_Ciudad_Ciudadid ;
         }
         if ( sdt.IsDirty("CiudadNombre") )
         {
            gxTv_SdtPais_Ciudad_Ciudadnombre = sdt.gxTv_SdtPais_Ciudad_Ciudadnombre ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "CiudadId" )]
      [  XmlElement( ElementName = "CiudadId"   )]
      public short gxTpr_Ciudadid
      {
         get {
            return gxTv_SdtPais_Ciudad_Ciudadid ;
         }

         set {
            gxTv_SdtPais_Ciudad_Ciudadid = value;
            gxTv_SdtPais_Ciudad_Modified = 1;
            SetDirty("Ciudadid");
         }

      }

      [  SoapElement( ElementName = "CiudadNombre" )]
      [  XmlElement( ElementName = "CiudadNombre"   )]
      public String gxTpr_Ciudadnombre
      {
         get {
            return gxTv_SdtPais_Ciudad_Ciudadnombre ;
         }

         set {
            gxTv_SdtPais_Ciudad_Ciudadnombre = value;
            gxTv_SdtPais_Ciudad_Modified = 1;
            SetDirty("Ciudadnombre");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtPais_Ciudad_Mode ;
         }

         set {
            gxTv_SdtPais_Ciudad_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtPais_Ciudad_Mode_SetNull( )
      {
         gxTv_SdtPais_Ciudad_Mode = "";
         return  ;
      }

      public bool gxTv_SdtPais_Ciudad_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Modified" )]
      [  XmlElement( ElementName = "Modified"   )]
      public short gxTpr_Modified
      {
         get {
            return gxTv_SdtPais_Ciudad_Modified ;
         }

         set {
            gxTv_SdtPais_Ciudad_Modified = value;
            SetDirty("Modified");
         }

      }

      public void gxTv_SdtPais_Ciudad_Modified_SetNull( )
      {
         gxTv_SdtPais_Ciudad_Modified = 0;
         return  ;
      }

      public bool gxTv_SdtPais_Ciudad_Modified_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtPais_Ciudad_Initialized ;
         }

         set {
            gxTv_SdtPais_Ciudad_Initialized = value;
            gxTv_SdtPais_Ciudad_Modified = 1;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtPais_Ciudad_Initialized_SetNull( )
      {
         gxTv_SdtPais_Ciudad_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtPais_Ciudad_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CiudadId_Z" )]
      [  XmlElement( ElementName = "CiudadId_Z"   )]
      public short gxTpr_Ciudadid_Z
      {
         get {
            return gxTv_SdtPais_Ciudad_Ciudadid_Z ;
         }

         set {
            gxTv_SdtPais_Ciudad_Ciudadid_Z = value;
            gxTv_SdtPais_Ciudad_Modified = 1;
            SetDirty("Ciudadid_Z");
         }

      }

      public void gxTv_SdtPais_Ciudad_Ciudadid_Z_SetNull( )
      {
         gxTv_SdtPais_Ciudad_Ciudadid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtPais_Ciudad_Ciudadid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CiudadNombre_Z" )]
      [  XmlElement( ElementName = "CiudadNombre_Z"   )]
      public String gxTpr_Ciudadnombre_Z
      {
         get {
            return gxTv_SdtPais_Ciudad_Ciudadnombre_Z ;
         }

         set {
            gxTv_SdtPais_Ciudad_Ciudadnombre_Z = value;
            gxTv_SdtPais_Ciudad_Modified = 1;
            SetDirty("Ciudadnombre_Z");
         }

      }

      public void gxTv_SdtPais_Ciudad_Ciudadnombre_Z_SetNull( )
      {
         gxTv_SdtPais_Ciudad_Ciudadnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtPais_Ciudad_Ciudadnombre_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtPais_Ciudad_Ciudadnombre = "";
         gxTv_SdtPais_Ciudad_Mode = "";
         gxTv_SdtPais_Ciudad_Ciudadnombre_Z = "";
         return  ;
      }

      private short gxTv_SdtPais_Ciudad_Ciudadid ;
      private short gxTv_SdtPais_Ciudad_Modified ;
      private short gxTv_SdtPais_Ciudad_Initialized ;
      private short gxTv_SdtPais_Ciudad_Ciudadid_Z ;
      private String gxTv_SdtPais_Ciudad_Ciudadnombre ;
      private String gxTv_SdtPais_Ciudad_Mode ;
      private String gxTv_SdtPais_Ciudad_Ciudadnombre_Z ;
   }

   [DataContract(Name = @"Pais.Ciudad", Namespace = "GXObligatorio1")]
   public class SdtPais_Ciudad_RESTInterface : GxGenericCollectionItem<SdtPais_Ciudad>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPais_Ciudad_RESTInterface( ) : base()
      {
      }

      public SdtPais_Ciudad_RESTInterface( SdtPais_Ciudad psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CiudadId" , Order = 0 )]
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

      [DataMember( Name = "CiudadNombre" , Order = 1 )]
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

      public SdtPais_Ciudad sdt
      {
         get {
            return (SdtPais_Ciudad)Sdt ;
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
            sdt = new SdtPais_Ciudad() ;
         }
      }

   }

}
