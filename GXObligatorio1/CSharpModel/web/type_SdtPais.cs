/*
               File: type_SdtPais
        Description: Pais
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:23.61
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
   [XmlRoot(ElementName = "Pais" )]
   [XmlType(TypeName =  "Pais" , Namespace = "GXObligatorio1" )]
   [Serializable]
   public class SdtPais : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPais( )
      {
      }

      public SdtPais( IGxContext context )
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

      public void Load( short AV1PaisId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV1PaisId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"PaisId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Pais");
         metadata.Set("BT", "Pais");
         metadata.Set("PK", "[ \"PaisId\" ]");
         metadata.Set("PKAssigned", "[ \"PaisId\" ]");
         metadata.Set("Levels", "[ \"Ciudad\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Paisbandera_gxi");
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Paisid_Z");
         state.Add("gxTpr_Paisnombre_Z");
         state.Add("gxTpr_Paisbandera_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtPais sdt ;
         sdt = (SdtPais)(source);
         gxTv_SdtPais_Paisid = sdt.gxTv_SdtPais_Paisid ;
         gxTv_SdtPais_Paisnombre = sdt.gxTv_SdtPais_Paisnombre ;
         gxTv_SdtPais_Paisbandera = sdt.gxTv_SdtPais_Paisbandera ;
         gxTv_SdtPais_Paisbandera_gxi = sdt.gxTv_SdtPais_Paisbandera_gxi ;
         gxTv_SdtPais_Ciudad = sdt.gxTv_SdtPais_Ciudad ;
         gxTv_SdtPais_Mode = sdt.gxTv_SdtPais_Mode ;
         gxTv_SdtPais_Initialized = sdt.gxTv_SdtPais_Initialized ;
         gxTv_SdtPais_Paisid_Z = sdt.gxTv_SdtPais_Paisid_Z ;
         gxTv_SdtPais_Paisnombre_Z = sdt.gxTv_SdtPais_Paisnombre_Z ;
         gxTv_SdtPais_Paisbandera_gxi_Z = sdt.gxTv_SdtPais_Paisbandera_gxi_Z ;
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
         AddObjectProperty("PaisId", gxTv_SdtPais_Paisid, false, includeNonInitialized);
         AddObjectProperty("PaisNombre", gxTv_SdtPais_Paisnombre, false, includeNonInitialized);
         AddObjectProperty("PaisBandera", gxTv_SdtPais_Paisbandera, false, includeNonInitialized);
         if ( gxTv_SdtPais_Ciudad != null )
         {
            AddObjectProperty("Ciudad", gxTv_SdtPais_Ciudad, includeState, includeNonInitialized);
         }
         if ( includeState )
         {
            AddObjectProperty("PaisBandera_GXI", gxTv_SdtPais_Paisbandera_gxi, false, includeNonInitialized);
            AddObjectProperty("Mode", gxTv_SdtPais_Mode, false, includeNonInitialized);
            AddObjectProperty("Initialized", gxTv_SdtPais_Initialized, false, includeNonInitialized);
            AddObjectProperty("PaisId_Z", gxTv_SdtPais_Paisid_Z, false, includeNonInitialized);
            AddObjectProperty("PaisNombre_Z", gxTv_SdtPais_Paisnombre_Z, false, includeNonInitialized);
            AddObjectProperty("PaisBandera_GXI_Z", gxTv_SdtPais_Paisbandera_gxi_Z, false, includeNonInitialized);
         }
         return  ;
      }

      public void UpdateDirties( SdtPais sdt )
      {
         if ( sdt.IsDirty("PaisId") )
         {
            gxTv_SdtPais_Paisid = sdt.gxTv_SdtPais_Paisid ;
         }
         if ( sdt.IsDirty("PaisNombre") )
         {
            gxTv_SdtPais_Paisnombre = sdt.gxTv_SdtPais_Paisnombre ;
         }
         if ( sdt.IsDirty("PaisBandera") )
         {
            gxTv_SdtPais_Paisbandera = sdt.gxTv_SdtPais_Paisbandera ;
         }
         if ( sdt.IsDirty("PaisBandera") )
         {
            gxTv_SdtPais_Paisbandera_gxi = sdt.gxTv_SdtPais_Paisbandera_gxi ;
         }
         if ( gxTv_SdtPais_Ciudad != null )
         {
            GXBCLevelCollection<SdtPais_Ciudad> newCollectionCiudad = sdt.gxTpr_Ciudad ;
            SdtPais_Ciudad currItemCiudad ;
            SdtPais_Ciudad newItemCiudad ;
            short idx = 1 ;
            while ( idx <= newCollectionCiudad.Count )
            {
               newItemCiudad = ((SdtPais_Ciudad)newCollectionCiudad.Item(idx));
               currItemCiudad = gxTv_SdtPais_Ciudad.GetByKey(newItemCiudad.gxTpr_Ciudadid);
               if ( StringUtil.StrCmp(currItemCiudad.gxTpr_Mode, "UPD") == 0 )
               {
                  currItemCiudad.UpdateDirties(newItemCiudad);
                  if ( StringUtil.StrCmp(newItemCiudad.gxTpr_Mode, "DLT") == 0 )
                  {
                     currItemCiudad.gxTpr_Mode = "DLT";
                  }
                  currItemCiudad.gxTpr_Modified = 1;
               }
               else
               {
                  gxTv_SdtPais_Ciudad.Add(newItemCiudad, 0);
               }
               idx = (short)(idx+1);
            }
         }
         return  ;
      }

      [  SoapElement( ElementName = "PaisId" )]
      [  XmlElement( ElementName = "PaisId"   )]
      public short gxTpr_Paisid
      {
         get {
            return gxTv_SdtPais_Paisid ;
         }

         set {
            if ( gxTv_SdtPais_Paisid != value )
            {
               gxTv_SdtPais_Mode = "INS";
               this.gxTv_SdtPais_Paisid_Z_SetNull( );
               this.gxTv_SdtPais_Paisnombre_Z_SetNull( );
               this.gxTv_SdtPais_Paisbandera_gxi_Z_SetNull( );
               if ( gxTv_SdtPais_Ciudad != null )
               {
                  GXBCLevelCollection<SdtPais_Ciudad> collectionCiudad = gxTv_SdtPais_Ciudad ;
                  SdtPais_Ciudad currItemCiudad ;
                  short idx = 1 ;
                  while ( idx <= collectionCiudad.Count )
                  {
                     currItemCiudad = ((SdtPais_Ciudad)collectionCiudad.Item(idx));
                     currItemCiudad.gxTpr_Mode = "INS";
                     currItemCiudad.gxTpr_Modified = 1;
                     idx = (short)(idx+1);
                  }
               }
            }
            gxTv_SdtPais_Paisid = value;
            SetDirty("Paisid");
         }

      }

      [  SoapElement( ElementName = "PaisNombre" )]
      [  XmlElement( ElementName = "PaisNombre"   )]
      public String gxTpr_Paisnombre
      {
         get {
            return gxTv_SdtPais_Paisnombre ;
         }

         set {
            gxTv_SdtPais_Paisnombre = value;
            SetDirty("Paisnombre");
         }

      }

      [  SoapElement( ElementName = "PaisBandera" )]
      [  XmlElement( ElementName = "PaisBandera"   )]
      [GxUpload()]
      public String gxTpr_Paisbandera
      {
         get {
            return gxTv_SdtPais_Paisbandera ;
         }

         set {
            gxTv_SdtPais_Paisbandera = value;
            SetDirty("Paisbandera");
         }

      }

      [  SoapElement( ElementName = "PaisBandera_GXI" )]
      [  XmlElement( ElementName = "PaisBandera_GXI"   )]
      public String gxTpr_Paisbandera_gxi
      {
         get {
            return gxTv_SdtPais_Paisbandera_gxi ;
         }

         set {
            gxTv_SdtPais_Paisbandera_gxi = value;
            SetDirty("Paisbandera_gxi");
         }

      }

      [  SoapElement( ElementName = "Ciudad" )]
      [  XmlArray( ElementName = "Ciudad"  )]
      [  XmlArrayItemAttribute( ElementName= "Pais.Ciudad"  , IsNullable=false)]
      public GXBCLevelCollection<SdtPais_Ciudad> gxTpr_Ciudad_GXBCLevelCollection
      {
         get {
            if ( gxTv_SdtPais_Ciudad == null )
            {
               gxTv_SdtPais_Ciudad = new GXBCLevelCollection<SdtPais_Ciudad>( context, "Pais.Ciudad", "GXObligatorio1");
            }
            return gxTv_SdtPais_Ciudad ;
         }

         set {
            if ( gxTv_SdtPais_Ciudad == null )
            {
               gxTv_SdtPais_Ciudad = new GXBCLevelCollection<SdtPais_Ciudad>( context, "Pais.Ciudad", "GXObligatorio1");
            }
            gxTv_SdtPais_Ciudad = value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public GXBCLevelCollection<SdtPais_Ciudad> gxTpr_Ciudad
      {
         get {
            if ( gxTv_SdtPais_Ciudad == null )
            {
               gxTv_SdtPais_Ciudad = new GXBCLevelCollection<SdtPais_Ciudad>( context, "Pais.Ciudad", "GXObligatorio1");
            }
            return gxTv_SdtPais_Ciudad ;
         }

         set {
            gxTv_SdtPais_Ciudad = value;
            SetDirty("Ciudad");
         }

      }

      public void gxTv_SdtPais_Ciudad_SetNull( )
      {
         gxTv_SdtPais_Ciudad = null;
         return  ;
      }

      public bool gxTv_SdtPais_Ciudad_IsNull( )
      {
         if ( gxTv_SdtPais_Ciudad == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtPais_Mode ;
         }

         set {
            gxTv_SdtPais_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtPais_Mode_SetNull( )
      {
         gxTv_SdtPais_Mode = "";
         return  ;
      }

      public bool gxTv_SdtPais_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtPais_Initialized ;
         }

         set {
            gxTv_SdtPais_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtPais_Initialized_SetNull( )
      {
         gxTv_SdtPais_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtPais_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PaisId_Z" )]
      [  XmlElement( ElementName = "PaisId_Z"   )]
      public short gxTpr_Paisid_Z
      {
         get {
            return gxTv_SdtPais_Paisid_Z ;
         }

         set {
            gxTv_SdtPais_Paisid_Z = value;
            SetDirty("Paisid_Z");
         }

      }

      public void gxTv_SdtPais_Paisid_Z_SetNull( )
      {
         gxTv_SdtPais_Paisid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtPais_Paisid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PaisNombre_Z" )]
      [  XmlElement( ElementName = "PaisNombre_Z"   )]
      public String gxTpr_Paisnombre_Z
      {
         get {
            return gxTv_SdtPais_Paisnombre_Z ;
         }

         set {
            gxTv_SdtPais_Paisnombre_Z = value;
            SetDirty("Paisnombre_Z");
         }

      }

      public void gxTv_SdtPais_Paisnombre_Z_SetNull( )
      {
         gxTv_SdtPais_Paisnombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtPais_Paisnombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "PaisBandera_GXI_Z" )]
      [  XmlElement( ElementName = "PaisBandera_GXI_Z"   )]
      public String gxTpr_Paisbandera_gxi_Z
      {
         get {
            return gxTv_SdtPais_Paisbandera_gxi_Z ;
         }

         set {
            gxTv_SdtPais_Paisbandera_gxi_Z = value;
            SetDirty("Paisbandera_gxi_Z");
         }

      }

      public void gxTv_SdtPais_Paisbandera_gxi_Z_SetNull( )
      {
         gxTv_SdtPais_Paisbandera_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtPais_Paisbandera_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtPais_Paisid = 1;
         gxTv_SdtPais_Paisnombre = "";
         gxTv_SdtPais_Paisbandera = "";
         gxTv_SdtPais_Paisbandera_gxi = "";
         gxTv_SdtPais_Mode = "";
         gxTv_SdtPais_Paisnombre_Z = "";
         gxTv_SdtPais_Paisbandera_gxi_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "pais", "GeneXus.Programs.pais_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtPais_Paisid ;
      private short gxTv_SdtPais_Initialized ;
      private short gxTv_SdtPais_Paisid_Z ;
      private String gxTv_SdtPais_Paisnombre ;
      private String gxTv_SdtPais_Mode ;
      private String gxTv_SdtPais_Paisnombre_Z ;
      private String gxTv_SdtPais_Paisbandera_gxi ;
      private String gxTv_SdtPais_Paisbandera_gxi_Z ;
      private String gxTv_SdtPais_Paisbandera ;
      private GXBCLevelCollection<SdtPais_Ciudad> gxTv_SdtPais_Ciudad=null ;
   }

   [DataContract(Name = @"Pais", Namespace = "GXObligatorio1")]
   public class SdtPais_RESTInterface : GxGenericCollectionItem<SdtPais>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtPais_RESTInterface( ) : base()
      {
      }

      public SdtPais_RESTInterface( SdtPais psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "PaisId" , Order = 0 )]
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

      [DataMember( Name = "PaisNombre" , Order = 1 )]
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

      [DataMember( Name = "PaisBandera" , Order = 2 )]
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

      [DataMember( Name = "Ciudad" , Order = 3 )]
      public GxGenericCollection<SdtPais_Ciudad_RESTInterface> gxTpr_Ciudad
      {
         get {
            return new GxGenericCollection<SdtPais_Ciudad_RESTInterface>(sdt.gxTpr_Ciudad) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Ciudad);
         }

      }

      public SdtPais sdt
      {
         get {
            return (SdtPais)Sdt ;
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
            sdt = new SdtPais() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 4 )]
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
