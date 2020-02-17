/*
               File: Localidad
        Description: Localidad
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 17:38:9.85
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
using System.Data;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class localidad : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false;
         gxfirstwebparm = GetNextPar( );
         gxfirstwebparm_bkp = gxfirstwebparm;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm);
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxfullajaxEvt") == 0 )
         {
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = GetNextPar( );
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridlocalidad_sector") == 0 )
         {
            nRC_GXsfl_68 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_68_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_68_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridlocalidad_sector_newrow( ) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp;
         }
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV7LocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV7LocalidadId", StringUtil.LTrimStr( (decimal)(AV7LocalidadId), 4, 0));
               AssignAttri("", false, "gxhash_vLOCALIDADID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7LocalidadId), "ZZZ9"), context));
            }
         }
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
         }
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_web_controls( ) ;
         if ( toggleJsOutput )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Localidad", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtLocalidadId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public localidad( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public localidad( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_LocalidadId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7LocalidadId = aP1_LocalidadId;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdmasterpage", "GeneXus.Programs.rwdmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
            if ( ( GxWebError == 0 ) && context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
               }
               if ( ! context.WillRedirect( ) )
               {
                  AddString( context.getJSONResponse( )) ;
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void fix_multi_value_controls( )
      {
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            DrawControls( ) ;
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void DrawControls( )
      {
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "WWAdvancedContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divTitlecontainer_Internalname, 1, 0, "px", 0, "px", "TableTop", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Localidad", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         ClassString = "ErrorViewer";
         StyleString = "";
         GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8 col-sm-offset-2", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divFormcontainer_Internalname, 1, 0, "px", 0, "px", "FormContainer", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divToolbarcell_Internalname, 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-sm-offset-3 ToolbarCellClass", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "btn-group", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"";
         ClassString = "BtnFirst";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCellAdvanced", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadNombre_Internalname, StringUtil.RTrim( A12LocalidadNombre), StringUtil.RTrim( context.localUtil.Format( A12LocalidadNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadCapacidad_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadCapacidad_Internalname, "Capacidad", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadCapacidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")), ((edtLocalidadCapacidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")) : context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadCapacidad_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadCapacidad_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadPrecio_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadPrecio_Internalname, "Precio", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")), ((edtLocalidadPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")) : context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadPrecio_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadPrecio_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadesVendidas_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadesVendidas_Internalname, "Vendidas", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadesVendidas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")), ((edtLocalidadesVendidas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A15LocalidadesVendidas), "ZZZZ9")) : context.localUtil.Format( (decimal)(A15LocalidadesVendidas), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadesVendidas_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadesVendidas_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLocalidadesDisponibles_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLocalidadesDisponibles_Internalname, "Disponibles", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLocalidadesDisponibles_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", "")), ((edtLocalidadesDisponibles_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")) : context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLocalidadesDisponibles_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLocalidadesDisponibles_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divSectortable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitlesector_Internalname, "Sector", "", "", lblTitlesector_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Gridlocalidad_sector( ) ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "Center", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group Confirm", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Localidad.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Gridlocalidad_sector( )
      {
         /*  Grid Control  */
         Gridlocalidad_sectorContainer.AddObjectProperty("GridName", "Gridlocalidad_sector");
         Gridlocalidad_sectorContainer.AddObjectProperty("Header", subGridlocalidad_sector_Header);
         Gridlocalidad_sectorContainer.AddObjectProperty("Class", "Grid");
         Gridlocalidad_sectorContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Backcolorstyle), 1, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("CmpContext", "");
         Gridlocalidad_sectorContainer.AddObjectProperty("InMasterPage", "false");
         Gridlocalidad_sectorColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlocalidad_sectorColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")));
         Gridlocalidad_sectorColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddColumnProperties(Gridlocalidad_sectorColumn);
         Gridlocalidad_sectorColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridlocalidad_sectorColumn.AddObjectProperty("Value", StringUtil.RTrim( A18SectorNombre));
         Gridlocalidad_sectorColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddColumnProperties(Gridlocalidad_sectorColumn);
         Gridlocalidad_sectorContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Selectedindex), 4, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Allowselection), 1, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Selectioncolor), 9, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Allowhovering), 1, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Hoveringcolor), 9, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Allowcollapsing), 1, 0, ".", "")));
         Gridlocalidad_sectorContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridlocalidad_sector_Collapsed), 1, 0, ".", "")));
         nGXsfl_68_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount6 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_6 = 1;
               ScanStart046( ) ;
               while ( RcdFound6 != 0 )
               {
                  init_level_properties6( ) ;
                  getByPrimaryKey046( ) ;
                  AddRow046( ) ;
                  ScanNext046( ) ;
               }
               ScanEnd046( ) ;
               nBlankRcdCount6 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal046( ) ;
            standaloneModal046( ) ;
            sMode6 = Gx_mode;
            while ( nGXsfl_68_idx < nRC_GXsfl_68 )
            {
               bGXsfl_68_Refreshing = true;
               ReadRow046( ) ;
               edtSectorId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORID_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_68_Refreshing);
               edtSectorNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORNOMBRE_"+sGXsfl_68_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtSectorNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorNombre_Enabled), 5, 0), !bGXsfl_68_Refreshing);
               if ( ( nRcdExists_6 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal046( ) ;
               }
               SendRow046( ) ;
               bGXsfl_68_Refreshing = false;
            }
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount6 = 5;
            nRcdExists_6 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart046( ) ;
               while ( RcdFound6 != 0 )
               {
                  sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_686( ) ;
                  init_level_properties6( ) ;
                  standaloneNotModal046( ) ;
                  getByPrimaryKey046( ) ;
                  standaloneModal046( ) ;
                  AddRow046( ) ;
                  ScanNext046( ) ;
               }
               ScanEnd046( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ! IsDsp( ) && ! IsDlt( ) )
         {
            sMode6 = Gx_mode;
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx+1), 4, 0), 4, "0");
            SubsflControlProps_686( ) ;
            InitAll046( ) ;
            init_level_properties6( ) ;
            nRcdExists_6 = 0;
            nIsMod_6 = 0;
            nRcdDeleted_6 = 0;
            nBlankRcdCount6 = (short)(nBlankRcdUsr6+nBlankRcdCount6);
            fRowAdded = 0;
            while ( nBlankRcdCount6 > 0 )
            {
               standaloneNotModal046( ) ;
               standaloneModal046( ) ;
               AddRow046( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtSectorId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount6 = (short)(nBlankRcdCount6-1);
            }
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Gridlocalidad_sectorContainer"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridlocalidad_sector", Gridlocalidad_sectorContainer);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridlocalidad_sectorContainerData", Gridlocalidad_sectorContainer.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridlocalidad_sectorContainerData"+"V", Gridlocalidad_sectorContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridlocalidad_sectorContainerData"+"V"+"\" value='"+Gridlocalidad_sectorContainer.GridValuesHidden()+"'/>") ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void UserMainFullajax( )
      {
         INITENV( ) ;
         INITTRN( ) ;
         UserMain( ) ;
         Draw( ) ;
         SendCloseFormHiddens( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E11042 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z11LocalidadId = (short)(context.localUtil.CToN( cgiGet( "Z11LocalidadId"), ".", ","));
               Z12LocalidadNombre = cgiGet( "Z12LocalidadNombre");
               Z13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( "Z13LocalidadCapacidad"), ".", ","));
               Z14LocalidadPrecio = context.localUtil.CToN( cgiGet( "Z14LocalidadPrecio"), ".", ",");
               Z15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( "Z15LocalidadesVendidas"), ".", ","));
               Z16LocalidadesDisponibles = (int)(context.localUtil.CToN( cgiGet( "Z16LocalidadesDisponibles"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_68 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_68"), ".", ","));
               AV7LocalidadId = (short)(context.localUtil.CToN( cgiGet( "vLOCALIDADID"), ".", ","));
               AV11Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LOCALIDADID");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A11LocalidadId = 0;
                  AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               }
               else
               {
                  A11LocalidadId = (short)(context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ","));
                  AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               }
               A12LocalidadNombre = cgiGet( edtLocalidadNombre_Internalname);
               AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LOCALIDADCAPACIDAD");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadCapacidad_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A13LocalidadCapacidad = 0;
                  AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
               }
               else
               {
                  A13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ","));
                  AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",") > 999999.99m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LOCALIDADPRECIO");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadPrecio_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A14LocalidadPrecio = 0;
                  AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
               }
               else
               {
                  A14LocalidadPrecio = context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",");
                  AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LOCALIDADESVENDIDAS");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadesVendidas_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A15LocalidadesVendidas = 0;
                  AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
               }
               else
               {
                  A15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ","));
                  AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LOCALIDADESDISPONIBLES");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadesDisponibles_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A16LocalidadesDisponibles = 0;
                  AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
               }
               else
               {
                  A16LocalidadesDisponibles = (int)(context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ","));
                  AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
               }
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Localidad");
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A11LocalidadId != Z11LocalidadId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("localidad:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
                  GxWebError = 1;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.HttpContext.Response.StatusCode = 403;
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
                  GXUtil.WriteLog("send_http_error_code " + 403.ToString());
                  AnyError = 1;
                  return  ;
               }
               /* Check if conditions changed and reset current page numbers */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  A11LocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  disable_std_buttons( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  if ( IsDsp( ) )
                  {
                     sMode5 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode5;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound5 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_040( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "LOCALIDADID");
                        AnyError = 1;
                        GX_FocusControl = edtLocalidadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName");
            EvtGridId = cgiGet( "_EventGridId");
            EvtRowId = cgiGet( "_EventRowId");
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1);
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1);
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12042 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           if ( ! IsDsp( ) )
                           {
                              btn_enter( ) ;
                           }
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4);
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                     }
                  }
                  context.wbHandled = 1;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E12042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll045( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         bttBtn_delete_Visible = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
         bttBtn_first_Visible = 0;
         AssignProp("", false, bttBtn_first_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_first_Visible), 5, 0), true);
         bttBtn_previous_Visible = 0;
         AssignProp("", false, bttBtn_previous_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_previous_Visible), 5, 0), true);
         bttBtn_next_Visible = 0;
         AssignProp("", false, bttBtn_next_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_next_Visible), 5, 0), true);
         bttBtn_last_Visible = 0;
         AssignProp("", false, bttBtn_last_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_last_Visible), 5, 0), true);
         bttBtn_select_Visible = 0;
         AssignProp("", false, bttBtn_select_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_select_Visible), 5, 0), true);
         if ( IsDsp( ) || IsDlt( ) )
         {
            bttBtn_delete_Visible = 0;
            AssignProp("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Visible), 5, 0), true);
            if ( IsDsp( ) )
            {
               bttBtn_enter_Visible = 0;
               AssignProp("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Visible), 5, 0), true);
            }
            DisableAttributes045( ) ;
         }
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( IsDlt( ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete", ""), 0, "", true);
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm", ""), 0, "", true);
            }
         }
      }

      protected void CONFIRM_040( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls045( ) ;
            }
            else
            {
               CheckExtendedTable045( ) ;
               CloseExtendedTableCursors045( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode5 = Gx_mode;
            CONFIRM_046( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode5;
               AssignAttri("", false, "Gx_mode", Gx_mode);
               AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
            }
            /* Restore parent mode. */
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_046( )
      {
         nGXsfl_68_idx = 0;
         while ( nGXsfl_68_idx < nRC_GXsfl_68 )
         {
            ReadRow046( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               GetKey046( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  if ( RcdFound6 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate046( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable046( ) ;
                        CloseExtendedTableCursors046( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "SECTORID_" + sGXsfl_68_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtSectorId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound6 != 0 )
                  {
                     if ( nRcdDeleted_6 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey046( ) ;
                        Load046( ) ;
                        BeforeValidate046( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls046( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_6 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate046( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable046( ) ;
                              CloseExtendedTableCursors046( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                                 AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
                     {
                        GXCCtl = "SECTORID_" + sGXsfl_68_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSectorId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSectorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSectorNombre_Internalname, StringUtil.RTrim( A18SectorNombre)) ;
            ChangePostValue( "ZT_"+"Z17SectorId_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18SectorNombre_"+sGXsfl_68_idx, StringUtil.RTrim( Z18SectorNombre)) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "SECTORID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SECTORNOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption040( )
      {
      }

      protected void E11042( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV11Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "GXObligatorio1");
      }

      protected void E12042( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwlocalidad.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM045( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z12LocalidadNombre = T00045_A12LocalidadNombre[0];
               Z13LocalidadCapacidad = T00045_A13LocalidadCapacidad[0];
               Z14LocalidadPrecio = T00045_A14LocalidadPrecio[0];
               Z15LocalidadesVendidas = T00045_A15LocalidadesVendidas[0];
               Z16LocalidadesDisponibles = T00045_A16LocalidadesDisponibles[0];
            }
            else
            {
               Z12LocalidadNombre = A12LocalidadNombre;
               Z13LocalidadCapacidad = A13LocalidadCapacidad;
               Z14LocalidadPrecio = A14LocalidadPrecio;
               Z15LocalidadesVendidas = A15LocalidadesVendidas;
               Z16LocalidadesDisponibles = A16LocalidadesDisponibles;
            }
         }
         if ( GX_JID == -4 )
         {
            Z11LocalidadId = A11LocalidadId;
            Z12LocalidadNombre = A12LocalidadNombre;
            Z13LocalidadCapacidad = A13LocalidadCapacidad;
            Z14LocalidadPrecio = A14LocalidadPrecio;
            Z15LocalidadesVendidas = A15LocalidadesVendidas;
            Z16LocalidadesDisponibles = A16LocalidadesDisponibles;
         }
      }

      protected void standaloneNotModal( )
      {
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV7LocalidadId) )
         {
            A11LocalidadId = AV7LocalidadId;
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
         }
         if ( ! (0==AV7LocalidadId) )
         {
            edtLocalidadId_Enabled = 0;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         }
         else
         {
            edtLocalidadId_Enabled = 1;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         }
         if ( ! (0==AV7LocalidadId) )
         {
            edtLocalidadId_Enabled = 0;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtn_enter_Enabled = 0;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         else
         {
            bttBtn_enter_Enabled = 1;
            AssignProp("", false, bttBtn_enter_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_enter_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            AV11Pgmname = "Localidad";
            AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
         }
      }

      protected void Load045( )
      {
         /* Using cursor T00046 */
         pr_default.execute(4, new Object[] {A11LocalidadId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound5 = 1;
            A12LocalidadNombre = T00046_A12LocalidadNombre[0];
            AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
            A13LocalidadCapacidad = T00046_A13LocalidadCapacidad[0];
            AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
            A14LocalidadPrecio = T00046_A14LocalidadPrecio[0];
            AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
            A15LocalidadesVendidas = T00046_A15LocalidadesVendidas[0];
            AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
            A16LocalidadesDisponibles = T00046_A16LocalidadesDisponibles[0];
            AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
            ZM045( -4) ;
         }
         pr_default.close(4);
         OnLoadActions045( ) ;
      }

      protected void OnLoadActions045( )
      {
         AV11Pgmname = "Localidad";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CheckExtendedTable045( )
      {
         nIsDirty_5 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV11Pgmname = "Localidad";
         AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
      }

      protected void CloseExtendedTableCursors045( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey045( )
      {
         /* Using cursor T00047 */
         pr_default.execute(5, new Object[] {A11LocalidadId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00045 */
         pr_default.execute(3, new Object[] {A11LocalidadId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM045( 4) ;
            RcdFound5 = 1;
            A11LocalidadId = T00045_A11LocalidadId[0];
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            A12LocalidadNombre = T00045_A12LocalidadNombre[0];
            AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
            A13LocalidadCapacidad = T00045_A13LocalidadCapacidad[0];
            AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
            A14LocalidadPrecio = T00045_A14LocalidadPrecio[0];
            AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
            A15LocalidadesVendidas = T00045_A15LocalidadesVendidas[0];
            AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
            A16LocalidadesDisponibles = T00045_A16LocalidadesDisponibles[0];
            AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
            Z11LocalidadId = A11LocalidadId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load045( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey045( ) ;
            }
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey045( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode5;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(3);
      }

      protected void getEqualNoModal( )
      {
         GetKey045( ) ;
         if ( RcdFound5 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound5 = 0;
         /* Using cursor T00048 */
         pr_default.execute(6, new Object[] {A11LocalidadId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00048_A11LocalidadId[0] < A11LocalidadId ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00048_A11LocalidadId[0] > A11LocalidadId ) ) )
            {
               A11LocalidadId = T00048_A11LocalidadId[0];
               AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound5 = 0;
         /* Using cursor T00049 */
         pr_default.execute(7, new Object[] {A11LocalidadId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00049_A11LocalidadId[0] > A11LocalidadId ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00049_A11LocalidadId[0] < A11LocalidadId ) ) )
            {
               A11LocalidadId = T00049_A11LocalidadId[0];
               AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
               RcdFound5 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey045( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtLocalidadId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert045( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A11LocalidadId != Z11LocalidadId )
               {
                  A11LocalidadId = Z11LocalidadId;
                  AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "LOCALIDADID");
                  AnyError = 1;
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update045( ) ;
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A11LocalidadId != Z11LocalidadId )
               {
                  /* Insert record */
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert045( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "";
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "LOCALIDADID");
                     AnyError = 1;
                     GX_FocusControl = edtLocalidadId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtLocalidadId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert045( ) ;
                     if ( AnyError == 1 )
                     {
                        GX_FocusControl = "";
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
         if ( IsUpd( ) || IsDlt( ) )
         {
            if ( AnyError == 0 )
            {
               context.nUserReturn = 1;
            }
         }
      }

      protected void btn_delete( )
      {
         if ( A11LocalidadId != Z11LocalidadId )
         {
            A11LocalidadId = Z11LocalidadId;
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "LOCALIDADID");
            AnyError = 1;
            GX_FocusControl = edtLocalidadId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtLocalidadId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency045( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00044 */
            pr_default.execute(2, new Object[] {A11LocalidadId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Localidad"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z12LocalidadNombre, T00044_A12LocalidadNombre[0]) != 0 ) || ( Z13LocalidadCapacidad != T00044_A13LocalidadCapacidad[0] ) || ( Z14LocalidadPrecio != T00044_A14LocalidadPrecio[0] ) || ( Z15LocalidadesVendidas != T00044_A15LocalidadesVendidas[0] ) || ( Z16LocalidadesDisponibles != T00044_A16LocalidadesDisponibles[0] ) )
            {
               if ( StringUtil.StrCmp(Z12LocalidadNombre, T00044_A12LocalidadNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("localidad:[seudo value changed for attri]"+"LocalidadNombre");
                  GXUtil.WriteLogRaw("Old: ",Z12LocalidadNombre);
                  GXUtil.WriteLogRaw("Current: ",T00044_A12LocalidadNombre[0]);
               }
               if ( Z13LocalidadCapacidad != T00044_A13LocalidadCapacidad[0] )
               {
                  GXUtil.WriteLog("localidad:[seudo value changed for attri]"+"LocalidadCapacidad");
                  GXUtil.WriteLogRaw("Old: ",Z13LocalidadCapacidad);
                  GXUtil.WriteLogRaw("Current: ",T00044_A13LocalidadCapacidad[0]);
               }
               if ( Z14LocalidadPrecio != T00044_A14LocalidadPrecio[0] )
               {
                  GXUtil.WriteLog("localidad:[seudo value changed for attri]"+"LocalidadPrecio");
                  GXUtil.WriteLogRaw("Old: ",Z14LocalidadPrecio);
                  GXUtil.WriteLogRaw("Current: ",T00044_A14LocalidadPrecio[0]);
               }
               if ( Z15LocalidadesVendidas != T00044_A15LocalidadesVendidas[0] )
               {
                  GXUtil.WriteLog("localidad:[seudo value changed for attri]"+"LocalidadesVendidas");
                  GXUtil.WriteLogRaw("Old: ",Z15LocalidadesVendidas);
                  GXUtil.WriteLogRaw("Current: ",T00044_A15LocalidadesVendidas[0]);
               }
               if ( Z16LocalidadesDisponibles != T00044_A16LocalidadesDisponibles[0] )
               {
                  GXUtil.WriteLog("localidad:[seudo value changed for attri]"+"LocalidadesDisponibles");
                  GXUtil.WriteLogRaw("Old: ",Z16LocalidadesDisponibles);
                  GXUtil.WriteLogRaw("Current: ",T00044_A16LocalidadesDisponibles[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Localidad"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM045( 0) ;
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000410 */
                     pr_default.execute(8, new Object[] {A11LocalidadId, A12LocalidadNombre, A13LocalidadCapacidad, A14LocalidadPrecio, A15LocalidadesVendidas, A16LocalidadesDisponibles});
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("Localidad") ;
                     if ( (pr_default.getStatus(8) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel045( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption040( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load045( ) ;
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void Update045( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable045( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm045( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate045( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000411 */
                     pr_default.execute(9, new Object[] {A12LocalidadNombre, A13LocalidadCapacidad, A14LocalidadPrecio, A15LocalidadesVendidas, A16LocalidadesDisponibles, A11LocalidadId});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("Localidad") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Localidad"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate045( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel045( ) ;
                           if ( AnyError == 0 )
                           {
                              if ( IsUpd( ) || IsDlt( ) )
                              {
                                 if ( AnyError == 0 )
                                 {
                                    context.nUserReturn = 1;
                                 }
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel045( ) ;
         }
         CloseExtendedTableCursors045( ) ;
      }

      protected void DeferredUpdate045( )
      {
      }

      protected void delete( )
      {
         BeforeValidate045( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency045( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls045( ) ;
            AfterConfirm045( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete045( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart046( ) ;
                  while ( RcdFound6 != 0 )
                  {
                     getByPrimaryKey046( ) ;
                     Delete046( ) ;
                     ScanNext046( ) ;
                  }
                  ScanEnd046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000412 */
                     pr_default.execute(10, new Object[] {A11LocalidadId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Localidad") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           if ( IsUpd( ) || IsDlt( ) )
                           {
                              if ( AnyError == 0 )
                              {
                                 context.nUserReturn = 1;
                              }
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
         }
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel045( ) ;
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls045( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV11Pgmname = "Localidad";
            AssignAttri("", false, "AV11Pgmname", AV11Pgmname);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000413 */
            pr_default.execute(11, new Object[] {A11LocalidadId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Localidad"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void ProcessNestedLevel046( )
      {
         nGXsfl_68_idx = 0;
         while ( nGXsfl_68_idx < nRC_GXsfl_68 )
         {
            ReadRow046( ) ;
            if ( ( nRcdExists_6 != 0 ) || ( nIsMod_6 != 0 ) )
            {
               standaloneNotModal046( ) ;
               GetKey046( ) ;
               if ( ( nRcdExists_6 == 0 ) && ( nRcdDeleted_6 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert046( ) ;
               }
               else
               {
                  if ( RcdFound6 != 0 )
                  {
                     if ( ( nRcdDeleted_6 != 0 ) && ( nRcdExists_6 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete046( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_6 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update046( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_6 == 0 )
                     {
                        GXCCtl = "SECTORID_" + sGXsfl_68_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtSectorId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSectorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSectorNombre_Internalname, StringUtil.RTrim( A18SectorNombre)) ;
            ChangePostValue( "ZT_"+"Z17SectorId_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18SectorNombre_"+sGXsfl_68_idx, StringUtil.RTrim( Z18SectorNombre)) ;
            ChangePostValue( "nRcdDeleted_6_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_6_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_6_"+sGXsfl_68_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", ""))) ;
            if ( nIsMod_6 != 0 )
            {
               ChangePostValue( "SECTORID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SECTORNOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll046( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_6 = 0;
         nIsMod_6 = 0;
         nRcdDeleted_6 = 0;
      }

      protected void ProcessLevel045( )
      {
         /* Save parent mode. */
         sMode5 = Gx_mode;
         ProcessNestedLevel046( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode5;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel045( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(2);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete045( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.CommitDataStores("localidad",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues040( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(3);
            pr_default.close(1);
            pr_default.close(0);
            context.RollbackDataStores("localidad",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart045( )
      {
         /* Scan By routine */
         /* Using cursor T000414 */
         pr_default.execute(12);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1;
            A11LocalidadId = T000414_A11LocalidadId[0];
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext045( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound5 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound5 = 1;
            A11LocalidadId = T000414_A11LocalidadId[0];
            AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
         }
      }

      protected void ScanEnd045( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm045( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert045( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate045( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete045( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete045( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate045( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes045( )
      {
         edtLocalidadId_Enabled = 0;
         AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), true);
         edtLocalidadNombre_Enabled = 0;
         AssignProp("", false, edtLocalidadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadNombre_Enabled), 5, 0), true);
         edtLocalidadCapacidad_Enabled = 0;
         AssignProp("", false, edtLocalidadCapacidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0), true);
         edtLocalidadPrecio_Enabled = 0;
         AssignProp("", false, edtLocalidadPrecio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadPrecio_Enabled), 5, 0), true);
         edtLocalidadesVendidas_Enabled = 0;
         AssignProp("", false, edtLocalidadesVendidas_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0), true);
         edtLocalidadesDisponibles_Enabled = 0;
         AssignProp("", false, edtLocalidadesDisponibles_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0), true);
      }

      protected void ZM046( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z18SectorNombre = T00043_A18SectorNombre[0];
            }
            else
            {
               Z18SectorNombre = A18SectorNombre;
            }
         }
         if ( GX_JID == -5 )
         {
            Z11LocalidadId = A11LocalidadId;
            Z17SectorId = A17SectorId;
            Z18SectorNombre = A18SectorNombre;
         }
      }

      protected void standaloneNotModal046( )
      {
      }

      protected void standaloneModal046( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSectorId_Enabled = 0;
            AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_68_Refreshing);
         }
         else
         {
            edtSectorId_Enabled = 1;
            AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_68_Refreshing);
         }
      }

      protected void Load046( )
      {
         /* Using cursor T000415 */
         pr_default.execute(13, new Object[] {A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(13) != 101) )
         {
            RcdFound6 = 1;
            A18SectorNombre = T000415_A18SectorNombre[0];
            ZM046( -5) ;
         }
         pr_default.close(13);
         OnLoadActions046( ) ;
      }

      protected void OnLoadActions046( )
      {
      }

      protected void CheckExtendedTable046( )
      {
         nIsDirty_6 = 0;
         Gx_BScreen = 1;
         standaloneModal046( ) ;
      }

      protected void CloseExtendedTableCursors046( )
      {
      }

      protected void enableDisable046( )
      {
      }

      protected void GetKey046( )
      {
         /* Using cursor T000416 */
         pr_default.execute(14, new Object[] {A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(14) != 101) )
         {
            RcdFound6 = 1;
         }
         else
         {
            RcdFound6 = 0;
         }
         pr_default.close(14);
      }

      protected void getByPrimaryKey046( )
      {
         /* Using cursor T00043 */
         pr_default.execute(1, new Object[] {A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM046( 5) ;
            RcdFound6 = 1;
            InitializeNonKey046( ) ;
            A17SectorId = T00043_A17SectorId[0];
            A18SectorNombre = T00043_A18SectorNombre[0];
            Z11LocalidadId = A11LocalidadId;
            Z17SectorId = A17SectorId;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load046( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound6 = 0;
            InitializeNonKey046( ) ;
            sMode6 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal046( ) ;
            Gx_mode = sMode6;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes046( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency046( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00042 */
            pr_default.execute(0, new Object[] {A11LocalidadId, A17SectorId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"LocalidadSector"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z18SectorNombre, T00042_A18SectorNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z18SectorNombre, T00042_A18SectorNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("localidad:[seudo value changed for attri]"+"SectorNombre");
                  GXUtil.WriteLogRaw("Old: ",Z18SectorNombre);
                  GXUtil.WriteLogRaw("Current: ",T00042_A18SectorNombre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"LocalidadSector"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM046( 0) ;
            CheckOptimisticConcurrency046( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm046( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert046( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000417 */
                     pr_default.execute(15, new Object[] {A11LocalidadId, A17SectorId, A18SectorNombre});
                     pr_default.close(15);
                     dsDefault.SmartCacheProvider.SetUpdated("LocalidadSector") ;
                     if ( (pr_default.getStatus(15) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load046( ) ;
            }
            EndLevel046( ) ;
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void Update046( )
      {
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable046( ) ;
         }
         if ( ( nIsMod_6 != 0 ) || ( nIsDirty_6 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency046( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm046( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate046( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000418 */
                        pr_default.execute(16, new Object[] {A18SectorNombre, A11LocalidadId, A17SectorId});
                        pr_default.close(16);
                        dsDefault.SmartCacheProvider.SetUpdated("LocalidadSector") ;
                        if ( (pr_default.getStatus(16) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"LocalidadSector"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate046( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey046( ) ;
                           }
                        }
                        else
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                           AnyError = 1;
                        }
                     }
                  }
               }
               EndLevel046( ) ;
            }
         }
         CloseExtendedTableCursors046( ) ;
      }

      protected void DeferredUpdate046( )
      {
      }

      protected void Delete046( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate046( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency046( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls046( ) ;
            AfterConfirm046( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete046( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000419 */
                  pr_default.execute(17, new Object[] {A11LocalidadId, A17SectorId});
                  pr_default.close(17);
                  dsDefault.SmartCacheProvider.SetUpdated("LocalidadSector") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode6 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel046( ) ;
         Gx_mode = sMode6;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls046( )
      {
         standaloneModal046( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel046( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart046( )
      {
         /* Scan By routine */
         /* Using cursor T000420 */
         pr_default.execute(18, new Object[] {A11LocalidadId});
         RcdFound6 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound6 = 1;
            A17SectorId = T000420_A17SectorId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext046( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound6 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound6 = 1;
            A17SectorId = T000420_A17SectorId[0];
         }
      }

      protected void ScanEnd046( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm046( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert046( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate046( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete046( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete046( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate046( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes046( )
      {
         edtSectorId_Enabled = 0;
         AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_68_Refreshing);
         edtSectorNombre_Enabled = 0;
         AssignProp("", false, edtSectorNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorNombre_Enabled), 5, 0), !bGXsfl_68_Refreshing);
      }

      protected void send_integrity_lvl_hashes046( )
      {
      }

      protected void send_integrity_lvl_hashes045( )
      {
      }

      protected void SubsflControlProps_686( )
      {
         edtSectorId_Internalname = "SECTORID_"+sGXsfl_68_idx;
         edtSectorNombre_Internalname = "SECTORNOMBRE_"+sGXsfl_68_idx;
      }

      protected void SubsflControlProps_fel_686( )
      {
         edtSectorId_Internalname = "SECTORID_"+sGXsfl_68_fel_idx;
         edtSectorNombre_Internalname = "SECTORNOMBRE_"+sGXsfl_68_fel_idx;
      }

      protected void AddRow046( )
      {
         nGXsfl_68_idx = (int)(nGXsfl_68_idx+1);
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx), 4, 0), 4, "0");
         SubsflControlProps_686( ) ;
         SendRow046( ) ;
      }

      protected void SendRow046( )
      {
         Gridlocalidad_sectorRow = GXWebRow.GetNew(context);
         if ( subGridlocalidad_sector_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridlocalidad_sector_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridlocalidad_sector_Class, "") != 0 )
            {
               subGridlocalidad_sector_Linesclass = subGridlocalidad_sector_Class+"Odd";
            }
         }
         else if ( subGridlocalidad_sector_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridlocalidad_sector_Backstyle = 0;
            subGridlocalidad_sector_Backcolor = subGridlocalidad_sector_Allbackcolor;
            if ( StringUtil.StrCmp(subGridlocalidad_sector_Class, "") != 0 )
            {
               subGridlocalidad_sector_Linesclass = subGridlocalidad_sector_Class+"Uniform";
            }
         }
         else if ( subGridlocalidad_sector_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridlocalidad_sector_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridlocalidad_sector_Class, "") != 0 )
            {
               subGridlocalidad_sector_Linesclass = subGridlocalidad_sector_Class+"Odd";
            }
            subGridlocalidad_sector_Backcolor = (int)(0x0);
         }
         else if ( subGridlocalidad_sector_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridlocalidad_sector_Backstyle = 1;
            if ( ((int)((nGXsfl_68_idx) % (2))) == 0 )
            {
               subGridlocalidad_sector_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridlocalidad_sector_Class, "") != 0 )
               {
                  subGridlocalidad_sector_Linesclass = subGridlocalidad_sector_Class+"Even";
               }
            }
            else
            {
               subGridlocalidad_sector_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridlocalidad_sector_Class, "") != 0 )
               {
                  subGridlocalidad_sector_Linesclass = subGridlocalidad_sector_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_68_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_68_idx + "',68)\"";
         ROClassString = "Attribute";
         Gridlocalidad_sectorRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSectorId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A17SectorId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,69);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSectorId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSectorId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_6_" + sGXsfl_68_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_68_idx + "',68)\"";
         ROClassString = "Attribute";
         Gridlocalidad_sectorRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSectorNombre_Internalname,StringUtil.RTrim( A18SectorNombre),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,70);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSectorNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSectorNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)68,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridlocalidad_sectorRow);
         send_integrity_lvl_hashes046( ) ;
         GXCCtl = "Z17SectorId_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", "")));
         GXCCtl = "Z18SectorNombre_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z18SectorNombre));
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_6), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_6_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_6), 4, 0, ".", "")));
         GXCCtl = "nIsMod_6_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_6), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_68_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vLOCALIDADID_" + sGXsfl_68_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7LocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SECTORID_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SECTORNOMBRE_"+sGXsfl_68_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridlocalidad_sectorContainer.AddRow(Gridlocalidad_sectorRow);
      }

      protected void ReadRow046( )
      {
         nGXsfl_68_idx = (int)(nGXsfl_68_idx+1);
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx), 4, 0), 4, "0");
         SubsflControlProps_686( ) ;
         edtSectorId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORID_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         edtSectorNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORNOMBRE_"+sGXsfl_68_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SECTORID_" + sGXsfl_68_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtSectorId_Internalname;
            wbErr = true;
            A17SectorId = 0;
         }
         else
         {
            A17SectorId = (short)(context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ","));
         }
         A18SectorNombre = cgiGet( edtSectorNombre_Internalname);
         GXCCtl = "Z17SectorId_" + sGXsfl_68_idx;
         Z17SectorId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z18SectorNombre_" + sGXsfl_68_idx;
         Z18SectorNombre = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_6_" + sGXsfl_68_idx;
         nRcdDeleted_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_6_" + sGXsfl_68_idx;
         nRcdExists_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_6_" + sGXsfl_68_idx;
         nIsMod_6 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtSectorId_Enabled = edtSectorId_Enabled;
      }

      protected void ConfirmValues040( )
      {
         nGXsfl_68_idx = 0;
         sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx), 4, 0), 4, "0");
         SubsflControlProps_686( ) ;
         while ( nGXsfl_68_idx < nRC_GXsfl_68 )
         {
            nGXsfl_68_idx = (int)(nGXsfl_68_idx+1);
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx), 4, 0), 4, "0");
            SubsflControlProps_686( ) ;
            ChangePostValue( "Z17SectorId_"+sGXsfl_68_idx, cgiGet( "ZT_"+"Z17SectorId_"+sGXsfl_68_idx)) ;
            DeletePostValue( "ZT_"+"Z17SectorId_"+sGXsfl_68_idx) ;
            ChangePostValue( "Z18SectorNombre_"+sGXsfl_68_idx, cgiGet( "ZT_"+"Z18SectorNombre_"+sGXsfl_68_idx)) ;
            DeletePostValue( "ZT_"+"Z18SectorNombre_"+sGXsfl_68_idx) ;
         }
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
      {
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( "<title>") ;
         context.SendWebValue( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202021617381111", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("localidad.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7LocalidadId)+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
         AssignProp("", false, "FORM", "Class", "form-horizontal Form", true);
         toggleJsOutput = isJsOutputEnabled( );
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"Localidad");
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("localidad:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z11LocalidadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11LocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z12LocalidadNombre", StringUtil.RTrim( Z12LocalidadNombre));
         GxWebStd.gx_hidden_field( context, "Z13LocalidadCapacidad", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13LocalidadCapacidad), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z14LocalidadPrecio", StringUtil.LTrim( StringUtil.NToC( Z14LocalidadPrecio, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z15LocalidadesVendidas", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15LocalidadesVendidas), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z16LocalidadesDisponibles", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16LocalidadesDisponibles), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_68", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_68_idx), 8, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vLOCALIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7LocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vLOCALIDADID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7LocalidadId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV11Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken(sPrefix);
         SendComponentObjects();
         SendServerCommands();
         SendState();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         context.WriteHtmlTextNl( "</form>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         context.WriteHtmlText( "<div") ;
         GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
         context.WriteHtmlText( ">") ;
         Draw( ) ;
         context.WriteHtmlText( "</div>") ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("localidad.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7LocalidadId) ;
      }

      public override String GetPgmname( )
      {
         return "Localidad" ;
      }

      public override String GetPgmdesc( )
      {
         return "Localidad" ;
      }

      protected void InitializeNonKey045( )
      {
         A12LocalidadNombre = "";
         AssignAttri("", false, "A12LocalidadNombre", A12LocalidadNombre);
         A13LocalidadCapacidad = 0;
         AssignAttri("", false, "A13LocalidadCapacidad", StringUtil.LTrimStr( (decimal)(A13LocalidadCapacidad), 5, 0));
         A14LocalidadPrecio = 0;
         AssignAttri("", false, "A14LocalidadPrecio", StringUtil.LTrimStr( A14LocalidadPrecio, 9, 2));
         A15LocalidadesVendidas = 0;
         AssignAttri("", false, "A15LocalidadesVendidas", StringUtil.LTrimStr( (decimal)(A15LocalidadesVendidas), 5, 0));
         A16LocalidadesDisponibles = 0;
         AssignAttri("", false, "A16LocalidadesDisponibles", StringUtil.LTrimStr( (decimal)(A16LocalidadesDisponibles), 5, 0));
         Z12LocalidadNombre = "";
         Z13LocalidadCapacidad = 0;
         Z14LocalidadPrecio = 0;
         Z15LocalidadesVendidas = 0;
         Z16LocalidadesDisponibles = 0;
      }

      protected void InitAll045( )
      {
         A11LocalidadId = 0;
         AssignAttri("", false, "A11LocalidadId", StringUtil.LTrimStr( (decimal)(A11LocalidadId), 4, 0));
         InitializeNonKey045( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey046( )
      {
         A18SectorNombre = "";
         Z18SectorNombre = "";
      }

      protected void InitAll046( )
      {
         A17SectorId = 0;
         InitializeNonKey046( ) ;
      }

      protected void StandaloneModalInsert046( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202021617381118", true, true);
            idxLst = (int)(idxLst+1);
         }
         if ( ! outputEnabled )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.eng.js", "?"+GetCacheInvalidationToken( ), false, true);
         context.AddJavascriptSource("localidad.js", "?202021617381118", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties6( )
      {
         edtSectorId_Enabled = defedtSectorId_Enabled;
         AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_68_Refreshing);
      }

      protected void init_default_properties( )
      {
         lblTitle_Internalname = "TITLE";
         divTitlecontainer_Internalname = "TITLECONTAINER";
         bttBtn_first_Internalname = "BTN_FIRST";
         bttBtn_previous_Internalname = "BTN_PREVIOUS";
         bttBtn_next_Internalname = "BTN_NEXT";
         bttBtn_last_Internalname = "BTN_LAST";
         bttBtn_select_Internalname = "BTN_SELECT";
         divToolbarcell_Internalname = "TOOLBARCELL";
         edtLocalidadId_Internalname = "LOCALIDADID";
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE";
         edtLocalidadCapacidad_Internalname = "LOCALIDADCAPACIDAD";
         edtLocalidadPrecio_Internalname = "LOCALIDADPRECIO";
         edtLocalidadesVendidas_Internalname = "LOCALIDADESVENDIDAS";
         edtLocalidadesDisponibles_Internalname = "LOCALIDADESDISPONIBLES";
         lblTitlesector_Internalname = "TITLESECTOR";
         edtSectorId_Internalname = "SECTORID";
         edtSectorNombre_Internalname = "SECTORNOMBRE";
         divSectortable_Internalname = "SECTORTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         subGridlocalidad_sector_Internalname = "GRIDLOCALIDAD_SECTOR";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Localidad";
         edtSectorNombre_Jsonclick = "";
         edtSectorId_Jsonclick = "";
         subGridlocalidad_sector_Class = "Grid";
         subGridlocalidad_sector_Backcolorstyle = 0;
         subGridlocalidad_sector_Allowcollapsing = 0;
         subGridlocalidad_sector_Allowselection = 0;
         edtSectorNombre_Enabled = 1;
         edtSectorId_Enabled = 1;
         subGridlocalidad_sector_Header = "";
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtLocalidadesDisponibles_Jsonclick = "";
         edtLocalidadesDisponibles_Enabled = 1;
         edtLocalidadesVendidas_Jsonclick = "";
         edtLocalidadesVendidas_Enabled = 1;
         edtLocalidadPrecio_Jsonclick = "";
         edtLocalidadPrecio_Enabled = 1;
         edtLocalidadCapacidad_Jsonclick = "";
         edtLocalidadCapacidad_Enabled = 1;
         edtLocalidadNombre_Jsonclick = "";
         edtLocalidadNombre_Enabled = 1;
         edtLocalidadId_Jsonclick = "";
         edtLocalidadId_Enabled = 1;
         bttBtn_select_Visible = 1;
         bttBtn_last_Visible = 1;
         bttBtn_next_Visible = 1;
         bttBtn_previous_Visible = 1;
         bttBtn_first_Visible = 1;
         context.GX_msglist.DisplayMode = 1;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridlocalidad_sector_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_686( ) ;
         while ( nGXsfl_68_idx <= nRC_GXsfl_68 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal046( ) ;
            standaloneModal046( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow046( ) ;
            nGXsfl_68_idx = (int)(nGXsfl_68_idx+1);
            sGXsfl_68_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_68_idx), 4, 0), 4, "0");
            SubsflControlProps_686( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridlocalidad_sectorContainer)) ;
         /* End function gxnrGridlocalidad_sector_newrow */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected bool IsIns( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "INS")==0) ? true : false) ;
      }

      protected bool IsDlt( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DLT")==0) ? true : false) ;
      }

      protected bool IsUpd( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "UPD")==0) ? true : false) ;
      }

      protected bool IsDsp( )
      {
         return ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? true : false) ;
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7LocalidadId',fld:'vLOCALIDADID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV7LocalidadId',fld:'vLOCALIDADID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12042',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_LOCALIDADID","{handler:'Valid_Localidadid',iparms:[]");
         setEventMetadata("VALID_LOCALIDADID",",oparms:[]}");
         setEventMetadata("VALID_SECTORID","{handler:'Valid_Sectorid',iparms:[]");
         setEventMetadata("VALID_SECTORID",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Sectornombre',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
         return  ;
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(3);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z12LocalidadNombre = "";
         Z18SectorNombre = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         lblTitle_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         TempTags = "";
         bttBtn_first_Jsonclick = "";
         bttBtn_previous_Jsonclick = "";
         bttBtn_next_Jsonclick = "";
         bttBtn_last_Jsonclick = "";
         bttBtn_select_Jsonclick = "";
         A12LocalidadNombre = "";
         lblTitlesector_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Gridlocalidad_sectorContainer = new GXWebGrid( context);
         Gridlocalidad_sectorColumn = new GXWebColumn();
         A18SectorNombre = "";
         sMode6 = "";
         sStyleString = "";
         AV11Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode5 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         T00046_A11LocalidadId = new short[1] ;
         T00046_A12LocalidadNombre = new String[] {""} ;
         T00046_A13LocalidadCapacidad = new int[1] ;
         T00046_A14LocalidadPrecio = new decimal[1] ;
         T00046_A15LocalidadesVendidas = new int[1] ;
         T00046_A16LocalidadesDisponibles = new int[1] ;
         T00047_A11LocalidadId = new short[1] ;
         T00045_A11LocalidadId = new short[1] ;
         T00045_A12LocalidadNombre = new String[] {""} ;
         T00045_A13LocalidadCapacidad = new int[1] ;
         T00045_A14LocalidadPrecio = new decimal[1] ;
         T00045_A15LocalidadesVendidas = new int[1] ;
         T00045_A16LocalidadesDisponibles = new int[1] ;
         T00048_A11LocalidadId = new short[1] ;
         T00049_A11LocalidadId = new short[1] ;
         T00044_A11LocalidadId = new short[1] ;
         T00044_A12LocalidadNombre = new String[] {""} ;
         T00044_A13LocalidadCapacidad = new int[1] ;
         T00044_A14LocalidadPrecio = new decimal[1] ;
         T00044_A15LocalidadesVendidas = new int[1] ;
         T00044_A16LocalidadesDisponibles = new int[1] ;
         T000413_A34EspectaculoId = new short[1] ;
         T000413_A11LocalidadId = new short[1] ;
         T000414_A11LocalidadId = new short[1] ;
         T000415_A11LocalidadId = new short[1] ;
         T000415_A17SectorId = new short[1] ;
         T000415_A18SectorNombre = new String[] {""} ;
         T000416_A11LocalidadId = new short[1] ;
         T000416_A17SectorId = new short[1] ;
         T00043_A11LocalidadId = new short[1] ;
         T00043_A17SectorId = new short[1] ;
         T00043_A18SectorNombre = new String[] {""} ;
         T00042_A11LocalidadId = new short[1] ;
         T00042_A17SectorId = new short[1] ;
         T00042_A18SectorNombre = new String[] {""} ;
         T000420_A11LocalidadId = new short[1] ;
         T000420_A17SectorId = new short[1] ;
         Gridlocalidad_sectorRow = new GXWebRow();
         subGridlocalidad_sector_Linesclass = "";
         ROClassString = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.localidad__default(),
            new Object[][] {
                new Object[] {
               T00042_A11LocalidadId, T00042_A17SectorId, T00042_A18SectorNombre
               }
               , new Object[] {
               T00043_A11LocalidadId, T00043_A17SectorId, T00043_A18SectorNombre
               }
               , new Object[] {
               T00044_A11LocalidadId, T00044_A12LocalidadNombre, T00044_A13LocalidadCapacidad, T00044_A14LocalidadPrecio, T00044_A15LocalidadesVendidas, T00044_A16LocalidadesDisponibles
               }
               , new Object[] {
               T00045_A11LocalidadId, T00045_A12LocalidadNombre, T00045_A13LocalidadCapacidad, T00045_A14LocalidadPrecio, T00045_A15LocalidadesVendidas, T00045_A16LocalidadesDisponibles
               }
               , new Object[] {
               T00046_A11LocalidadId, T00046_A12LocalidadNombre, T00046_A13LocalidadCapacidad, T00046_A14LocalidadPrecio, T00046_A15LocalidadesVendidas, T00046_A16LocalidadesDisponibles
               }
               , new Object[] {
               T00047_A11LocalidadId
               }
               , new Object[] {
               T00048_A11LocalidadId
               }
               , new Object[] {
               T00049_A11LocalidadId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000413_A34EspectaculoId, T000413_A11LocalidadId
               }
               , new Object[] {
               T000414_A11LocalidadId
               }
               , new Object[] {
               T000415_A11LocalidadId, T000415_A17SectorId, T000415_A18SectorNombre
               }
               , new Object[] {
               T000416_A11LocalidadId, T000416_A17SectorId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000420_A11LocalidadId, T000420_A17SectorId
               }
            }
         );
         AV11Pgmname = "Localidad";
      }

      private short wcpOAV7LocalidadId ;
      private short Z11LocalidadId ;
      private short Z17SectorId ;
      private short nRcdDeleted_6 ;
      private short nRcdExists_6 ;
      private short nIsMod_6 ;
      private short GxWebError ;
      private short AV7LocalidadId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A11LocalidadId ;
      private short subGridlocalidad_sector_Backcolorstyle ;
      private short A17SectorId ;
      private short subGridlocalidad_sector_Allowselection ;
      private short subGridlocalidad_sector_Allowhovering ;
      private short subGridlocalidad_sector_Allowcollapsing ;
      private short subGridlocalidad_sector_Collapsed ;
      private short nBlankRcdCount6 ;
      private short RcdFound6 ;
      private short nBlankRcdUsr6 ;
      private short RcdFound5 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short nIsDirty_5 ;
      private short nIsDirty_6 ;
      private short subGridlocalidad_sector_Backstyle ;
      private short gxajaxcallmode ;
      private int Z13LocalidadCapacidad ;
      private int Z15LocalidadesVendidas ;
      private int Z16LocalidadesDisponibles ;
      private int nRC_GXsfl_68 ;
      private int nGXsfl_68_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtLocalidadId_Enabled ;
      private int edtLocalidadNombre_Enabled ;
      private int A13LocalidadCapacidad ;
      private int edtLocalidadCapacidad_Enabled ;
      private int edtLocalidadPrecio_Enabled ;
      private int A15LocalidadesVendidas ;
      private int edtLocalidadesVendidas_Enabled ;
      private int A16LocalidadesDisponibles ;
      private int edtLocalidadesDisponibles_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtSectorId_Enabled ;
      private int edtSectorNombre_Enabled ;
      private int subGridlocalidad_sector_Selectedindex ;
      private int subGridlocalidad_sector_Selectioncolor ;
      private int subGridlocalidad_sector_Hoveringcolor ;
      private int fRowAdded ;
      private int subGridlocalidad_sector_Backcolor ;
      private int subGridlocalidad_sector_Allbackcolor ;
      private int defedtSectorId_Enabled ;
      private int idxLst ;
      private long GRIDLOCALIDAD_SECTOR_nFirstRecordOnPage ;
      private decimal Z14LocalidadPrecio ;
      private decimal A14LocalidadPrecio ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z12LocalidadNombre ;
      private String Z18SectorNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_68_idx="0001" ;
      private String Gx_mode ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtLocalidadId_Internalname ;
      private String divMaintable_Internalname ;
      private String divTitlecontainer_Internalname ;
      private String lblTitle_Internalname ;
      private String lblTitle_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divFormcontainer_Internalname ;
      private String divToolbarcell_Internalname ;
      private String TempTags ;
      private String bttBtn_first_Internalname ;
      private String bttBtn_first_Jsonclick ;
      private String bttBtn_previous_Internalname ;
      private String bttBtn_previous_Jsonclick ;
      private String bttBtn_next_Internalname ;
      private String bttBtn_next_Jsonclick ;
      private String bttBtn_last_Internalname ;
      private String bttBtn_last_Jsonclick ;
      private String bttBtn_select_Internalname ;
      private String bttBtn_select_Jsonclick ;
      private String edtLocalidadId_Jsonclick ;
      private String edtLocalidadNombre_Internalname ;
      private String A12LocalidadNombre ;
      private String edtLocalidadNombre_Jsonclick ;
      private String edtLocalidadCapacidad_Internalname ;
      private String edtLocalidadCapacidad_Jsonclick ;
      private String edtLocalidadPrecio_Internalname ;
      private String edtLocalidadPrecio_Jsonclick ;
      private String edtLocalidadesVendidas_Internalname ;
      private String edtLocalidadesVendidas_Jsonclick ;
      private String edtLocalidadesDisponibles_Internalname ;
      private String edtLocalidadesDisponibles_Jsonclick ;
      private String divSectortable_Internalname ;
      private String lblTitlesector_Internalname ;
      private String lblTitlesector_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGridlocalidad_sector_Header ;
      private String A18SectorNombre ;
      private String sMode6 ;
      private String edtSectorId_Internalname ;
      private String edtSectorNombre_Internalname ;
      private String sStyleString ;
      private String AV11Pgmname ;
      private String hsh ;
      private String sMode5 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String sGXsfl_68_fel_idx="0001" ;
      private String subGridlocalidad_sector_Class ;
      private String subGridlocalidad_sector_Linesclass ;
      private String ROClassString ;
      private String edtSectorId_Jsonclick ;
      private String edtSectorNombre_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String subGridlocalidad_sector_Internalname ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool bGXsfl_68_Refreshing=false ;
      private bool returnInSub ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private GXWebGrid Gridlocalidad_sectorContainer ;
      private GXWebRow Gridlocalidad_sectorRow ;
      private GXWebColumn Gridlocalidad_sectorColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00046_A11LocalidadId ;
      private String[] T00046_A12LocalidadNombre ;
      private int[] T00046_A13LocalidadCapacidad ;
      private decimal[] T00046_A14LocalidadPrecio ;
      private int[] T00046_A15LocalidadesVendidas ;
      private int[] T00046_A16LocalidadesDisponibles ;
      private short[] T00047_A11LocalidadId ;
      private short[] T00045_A11LocalidadId ;
      private String[] T00045_A12LocalidadNombre ;
      private int[] T00045_A13LocalidadCapacidad ;
      private decimal[] T00045_A14LocalidadPrecio ;
      private int[] T00045_A15LocalidadesVendidas ;
      private int[] T00045_A16LocalidadesDisponibles ;
      private short[] T00048_A11LocalidadId ;
      private short[] T00049_A11LocalidadId ;
      private short[] T00044_A11LocalidadId ;
      private String[] T00044_A12LocalidadNombre ;
      private int[] T00044_A13LocalidadCapacidad ;
      private decimal[] T00044_A14LocalidadPrecio ;
      private int[] T00044_A15LocalidadesVendidas ;
      private int[] T00044_A16LocalidadesDisponibles ;
      private short[] T000413_A34EspectaculoId ;
      private short[] T000413_A11LocalidadId ;
      private short[] T000414_A11LocalidadId ;
      private short[] T000415_A11LocalidadId ;
      private short[] T000415_A17SectorId ;
      private String[] T000415_A18SectorNombre ;
      private short[] T000416_A11LocalidadId ;
      private short[] T000416_A17SectorId ;
      private short[] T00043_A11LocalidadId ;
      private short[] T00043_A17SectorId ;
      private String[] T00043_A18SectorNombre ;
      private short[] T00042_A11LocalidadId ;
      private short[] T00042_A17SectorId ;
      private String[] T00042_A18SectorNombre ;
      private short[] T000420_A11LocalidadId ;
      private short[] T000420_A17SectorId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
   }

   public class localidad__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new UpdateCursor(def[16])
         ,new UpdateCursor(def[17])
         ,new ForEachCursor(def[18])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00046 ;
          prmT00046 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00047 ;
          prmT00047 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00045 ;
          prmT00045 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00048 ;
          prmT00048 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00049 ;
          prmT00049 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00044 ;
          prmT00044 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000410 ;
          prmT000410 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@LocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadesDisponibles",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000411 ;
          prmT000411 = new Object[] {
          new Object[] {"@LocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@LocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadesDisponibles",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000412 ;
          prmT000412 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000413 ;
          prmT000413 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000414 ;
          prmT000414 = new Object[] {
          } ;
          Object[] prmT000415 ;
          prmT000415 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000416 ;
          prmT000416 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00043 ;
          prmT00043 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00042 ;
          prmT00042 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000417 ;
          prmT000417 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorNombre",SqlDbType.NChar,100,0}
          } ;
          Object[] prmT000418 ;
          prmT000418 = new Object[] {
          new Object[] {"@SectorNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000419 ;
          prmT000419 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000420 ;
          prmT000420 = new Object[] {
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00042", "SELECT [LocalidadId], [SectorId], [SectorNombre] FROM [LocalidadSector] WITH (UPDLOCK) WHERE [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00042,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00043", "SELECT [LocalidadId], [SectorId], [SectorNombre] FROM [LocalidadSector] WHERE [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00043,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00044", "SELECT [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles] FROM [Localidad] WITH (UPDLOCK) WHERE [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00044,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00045", "SELECT [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles] FROM [Localidad] WHERE [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00045,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00046", "SELECT TM1.[LocalidadId], TM1.[LocalidadNombre], TM1.[LocalidadCapacidad], TM1.[LocalidadPrecio], TM1.[LocalidadesVendidas], TM1.[LocalidadesDisponibles] FROM [Localidad] TM1 WHERE TM1.[LocalidadId] = @LocalidadId ORDER BY TM1.[LocalidadId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00046,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00047", "SELECT [LocalidadId] FROM [Localidad] WHERE [LocalidadId] = @LocalidadId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00047,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00048", "SELECT TOP 1 [LocalidadId] FROM [Localidad] WHERE ( [LocalidadId] > @LocalidadId) ORDER BY [LocalidadId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00048,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T00049", "SELECT TOP 1 [LocalidadId] FROM [Localidad] WHERE ( [LocalidadId] < @LocalidadId) ORDER BY [LocalidadId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00049,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000410", "INSERT INTO [Localidad]([LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles]) VALUES(@LocalidadId, @LocalidadNombre, @LocalidadCapacidad, @LocalidadPrecio, @LocalidadesVendidas, @LocalidadesDisponibles)", GxErrorMask.GX_NOMASK,prmT000410)
             ,new CursorDef("T000411", "UPDATE [Localidad] SET [LocalidadNombre]=@LocalidadNombre, [LocalidadCapacidad]=@LocalidadCapacidad, [LocalidadPrecio]=@LocalidadPrecio, [LocalidadesVendidas]=@LocalidadesVendidas, [LocalidadesDisponibles]=@LocalidadesDisponibles  WHERE [LocalidadId] = @LocalidadId", GxErrorMask.GX_NOMASK,prmT000411)
             ,new CursorDef("T000412", "DELETE FROM [Localidad]  WHERE [LocalidadId] = @LocalidadId", GxErrorMask.GX_NOMASK,prmT000412)
             ,new CursorDef("T000413", "SELECT TOP 1 [EspectaculoId], [LocalidadId] FROM [EspectaculoLocalidad] WHERE [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000413,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000414", "SELECT [LocalidadId] FROM [Localidad] ORDER BY [LocalidadId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000414,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000415", "SELECT [LocalidadId], [SectorId], [SectorNombre] FROM [LocalidadSector] WHERE [LocalidadId] = @LocalidadId and [SectorId] = @SectorId ORDER BY [LocalidadId], [SectorId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000415,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000416", "SELECT [LocalidadId], [SectorId] FROM [LocalidadSector] WHERE [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000416,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000417", "INSERT INTO [LocalidadSector]([LocalidadId], [SectorId], [SectorNombre]) VALUES(@LocalidadId, @SectorId, @SectorNombre)", GxErrorMask.GX_NOMASK,prmT000417)
             ,new CursorDef("T000418", "UPDATE [LocalidadSector] SET [SectorNombre]=@SectorNombre  WHERE [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId", GxErrorMask.GX_NOMASK,prmT000418)
             ,new CursorDef("T000419", "DELETE FROM [LocalidadSector]  WHERE [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId", GxErrorMask.GX_NOMASK,prmT000419)
             ,new CursorDef("T000420", "SELECT [LocalidadId], [SectorId] FROM [LocalidadSector] WHERE [LocalidadId] = @LocalidadId ORDER BY [LocalidadId], [SectorId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000420,11, GxCacheFrequency.OFF ,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((decimal[]) buf[3])[0] = rslt.getDecimal(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                return;
             case 14 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 18 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                return;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                return;
             case 16 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}
