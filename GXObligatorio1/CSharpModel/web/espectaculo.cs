/*
               File: Espectaculo
        Description: Espectaculo
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/17/2020 0:13:3.42
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
   public class espectaculo : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_27") == 0 )
         {
            A6TipoEspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_27( A6TipoEspectaculoId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_28") == 0 )
         {
            A19EspectaculoPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_28( A19EspectaculoPaisId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_30") == 0 )
         {
            A19EspectaculoPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A22EspectaculoCiudadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_30( A19EspectaculoPaisId, A22EspectaculoCiudadId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_26") == 0 )
         {
            A8LugarId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_26( A8LugarId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_29") == 0 )
         {
            A29LugarPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_29( A29LugarPaisId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_31") == 0 )
         {
            A29LugarPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
            A32LugarCiudadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
            AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_31( A29LugarPaisId, A32LugarCiudadId) ;
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridespectaculo_localidad_sector") == 0 )
         {
            nRC_GXsfl_171 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_171_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_171_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGridespectaculo_localidad_sector_newrow( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
         {
            nRC_GXsfl_128 = (int)(NumberUtil.Val( GetNextPar( ), "."));
            nGXsfl_128_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
            sGXsfl_128_idx = GetNextPar( );
            Gx_mode = GetNextPar( );
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxnrGrid1_newrow( ) ;
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
               AV19EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AssignAttri("", false, "AV19EspectaculoId", StringUtil.LTrimStr( (decimal)(AV19EspectaculoId), 4, 0));
               AssignAttri("", false, "gxhash_vESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19EspectaculoId), "ZZZ9"), context));
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
            Form.Meta.addItem("description", "Espectaculo", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtEspectaculoId_Internalname;
         AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("Carmine");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public espectaculo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public espectaculo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( String aP0_Gx_mode ,
                           short aP1_EspectaculoId )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV19EspectaculoId = aP1_EspectaculoId;
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
         GxWebStd.gx_label_ctrl( context, lblTitle_Internalname, "Espectaculo", "", "", lblTitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Espectaculo.htm");
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
         GxWebStd.gx_button_ctrl( context, bttBtn_first_Internalname, "", "", bttBtn_first_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_first_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EFIRST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"";
         ClassString = "BtnPrevious";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_previous_Internalname, "", "", bttBtn_previous_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_previous_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"EPREVIOUS."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
         ClassString = "BtnNext";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_next_Internalname, "", "", bttBtn_next_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_next_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ENEXT."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'',0)\"";
         ClassString = "BtnLast";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_last_Internalname, "", "", bttBtn_last_Jsonclick, 5, "", "", StyleString, ClassString, bttBtn_last_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ELAST."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
         ClassString = "BtnSelect";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_select_Internalname, "", "Select", bttBtn_select_Jsonclick, 5, "Select", "", StyleString, ClassString, bttBtn_select_Visible, 0, "standard", "'"+""+"'"+",false,"+"'"+"ESELECT."+"'", TempTags, "", 2, "HLP_Espectaculo.htm");
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
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoId_Internalname, "Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoNombre_Internalname, "Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEspectaculoNombre_Internalname, StringUtil.RTrim( A35EspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,39);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoFecha_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoFecha_Internalname, "Fecha", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'',0)\"";
         context.WriteHtmlText( "<div id=\""+edtEspectaculoFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
         GxWebStd.gx_single_line_edit( context, edtEspectaculoFecha_Internalname, context.localUtil.Format(A36EspectaculoFecha, "99/99/99"), context.localUtil.Format( A36EspectaculoFecha, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoFecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoFecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_bitmap( context, edtEspectaculoFecha_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtEspectaculoFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_Espectaculo.htm");
         context.WriteHtmlTextNl( "</div>") ;
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoEspectaculoId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTipoEspectaculoId_Internalname, "Tipo Espectaculo Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtTipoEspectaculoId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TipoEspectaculoId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A6TipoEspectaculoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoEspectaculoId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipoEspectaculoId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_6_Internalname, sImgUrl, imgprompt_6_Link, "", "", context.GetTheme( ), imgprompt_6_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtTipoEspectaculoNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtTipoEspectaculoNombre_Internalname, "Tipo Espectaculo Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtTipoEspectaculoNombre_Internalname, StringUtil.RTrim( A7TipoEspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A7TipoEspectaculoNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtTipoEspectaculoNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtTipoEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoPaisId_Internalname, "Pais Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19EspectaculoPaisId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoPaisId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_19_Internalname, sImgUrl, imgprompt_19_Link, "", "", context.GetTheme( ), imgprompt_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoPaisNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoPaisNombre_Internalname, "Pais Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoPaisNombre_Internalname, StringUtil.RTrim( A20EspectaculoPaisNombre), StringUtil.RTrim( context.localUtil.Format( A20EspectaculoPaisNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoPaisNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgEspectaculoPaisBandera_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Pais Bandera", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         ClassString = "Attribute";
         StyleString = "";
         A21EspectaculoPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40000EspectaculoPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera));
         GxWebStd.gx_bitmap( context, imgEspectaculoPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgEspectaculoPaisBandera_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A21EspectaculoPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.PathToRelativeUrl( A21EspectaculoPaisBandera)), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "IsBlob", StringUtil.BoolToStr( A21EspectaculoPaisBandera_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoCiudadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoCiudadId_Internalname, "Ciudad Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A22EspectaculoCiudadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoCiudadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_22_Internalname, sImgUrl, imgprompt_22_Link, "", "", context.GetTheme( ), imgprompt_22_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoCiudadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtEspectaculoCiudadNombre_Internalname, "Ciudad Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtEspectaculoCiudadNombre_Internalname, StringUtil.RTrim( A23EspectaculoCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A23EspectaculoCiudadNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoCiudadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtEspectaculoCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarId_Internalname, "Lugar Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 84,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLugarId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,84);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_8_Internalname, sImgUrl, imgprompt_8_Link, "", "", context.GetTheme( ), imgprompt_8_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarNombre_Internalname, "Lugar Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtLugarNombre_Internalname, StringUtil.RTrim( A9LugarNombre), StringUtil.RTrim( context.localUtil.Format( A9LugarNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgLugarFoto_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Lugar Foto", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         ClassString = "Attribute";
         StyleString = "";
         A10LugarFoto_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto))&&String.IsNullOrEmpty(StringUtil.RTrim( A40001LugarFoto_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.PathToRelativeUrl( A10LugarFoto));
         GxWebStd.gx_bitmap( context, imgLugarFoto_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgLugarFoto_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A10LugarFoto_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         AssignProp("", false, imgLugarFoto_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.PathToRelativeUrl( A10LugarFoto)), true);
         AssignProp("", false, imgLugarFoto_Internalname, "IsBlob", StringUtil.BoolToStr( A10LugarFoto_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarPaisId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarPaisId_Internalname, "Pais Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLugarPaisId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29LugarPaisId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A29LugarPaisId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarPaisId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarPaisId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_29_Internalname, sImgUrl, imgprompt_29_Link, "", "", context.GetTheme( ), imgprompt_29_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarPaisNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarPaisNombre_Internalname, "Pais Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtLugarPaisNombre_Internalname, StringUtil.RTrim( A30LugarPaisNombre), StringUtil.RTrim( context.localUtil.Format( A30LugarPaisNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarPaisNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarPaisNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+imgLugarPaisBandera_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, "", "Pais Bandera", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Static Bitmap Variable */
         ClassString = "Attribute";
         StyleString = "";
         A31LugarPaisBandera_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera))&&String.IsNullOrEmpty(StringUtil.RTrim( A40002LugarPaisBandera_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)));
         sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.PathToRelativeUrl( A31LugarPaisBandera));
         GxWebStd.gx_bitmap( context, imgLugarPaisBandera_Internalname, sImgUrl, "", "", "", context.GetTheme( ), 1, imgLugarPaisBandera_Enabled, "", "", 1, -1, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 0, A31LugarPaisBandera_IsBlob, true, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         AssignProp("", false, imgLugarPaisBandera_Internalname, "URL", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.PathToRelativeUrl( A31LugarPaisBandera)), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "IsBlob", StringUtil.BoolToStr( A31LugarPaisBandera_IsBlob), true);
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarCiudadId_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarCiudadId_Internalname, "Ciudad Id", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"";
         GxWebStd.gx_single_line_edit( context, edtLugarCiudadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32LugarCiudadId), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A32LugarCiudadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,114);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarCiudadId_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarCiudadId_Enabled, 1, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "Id", "right", false, "", "HLP_Espectaculo.htm");
         /* Static images/pictures */
         ClassString = "gx-prompt Image";
         StyleString = "";
         sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
         GxWebStd.gx_bitmap( context, imgprompt_32_Internalname, sImgUrl, imgprompt_32_Link, "", "", context.GetTheme( ), imgprompt_32_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtLugarCiudadNombre_Internalname+"\"", "", "div");
         /* Attribute/Variable Label */
         GxWebStd.gx_label_element( context, edtLugarCiudadNombre_Internalname, "Ciudad Nombre", "col-sm-3 AttributeLabel", 1, true);
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
         /* Single line edit */
         GxWebStd.gx_single_line_edit( context, edtLugarCiudadNombre_Internalname, StringUtil.RTrim( A33LugarCiudadNombre), StringUtil.RTrim( context.localUtil.Format( A33LugarCiudadNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtLugarCiudadNombre_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtLugarCiudadNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, divLocalidadtable_Internalname, 1, 0, "px", 0, "px", "LevelTable", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 FormCell", "left", "top", "", "", "div");
         /* Text block */
         GxWebStd.gx_label_ctrl( context, lblTitlelocalidad_Internalname, "Localidad", "", "", lblTitlelocalidad_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Title", 0, "", 1, 1, 0, "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
         gxdraw_Grid1( ) ;
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
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 178,'',false,'',0)\"";
         ClassString = "BtnEnter";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirm", bttBtn_enter_Jsonclick, 5, "Confirm", "", StyleString, ClassString, bttBtn_enter_Visible, bttBtn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 180,'',false,'',0)\"";
         ClassString = "BtnCancel";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         /* Div Control */
         GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
         TempTags = "  onfocus=\"gx.evt.onfocus(this, 182,'',false,'',0)\"";
         ClassString = "BtnDelete";
         StyleString = "";
         GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Delete", bttBtn_delete_Jsonclick, 5, "Delete", "", StyleString, ClassString, bttBtn_delete_Visible, bttBtn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_Espectaculo.htm");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "Center", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
         GxWebStd.gx_div_end( context, "left", "top", "div");
      }

      protected void gxdraw_Grid1( )
      {
         /*  Grid Control  */
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("Header", subGrid1_Header);
         Grid1Container.AddObjectProperty("Class", StringUtil.RTrim( "TrnSublevelGrid"));
         Grid1Container.AddObjectProperty("Class", "TrnSublevelGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadId_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12LocalidadNombre));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadNombre_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadPrecio_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", "")));
         Grid1Column.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0, ".", "")));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Column.AddObjectProperty("Value", lblTitlesector_Caption);
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
         Grid1Container.AddColumnProperties(Grid1Column);
         Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
         Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
         Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
         /* Save parent mode. */
         sMode14 = Gx_mode;
         nGXsfl_128_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount14 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_14 = 1;
               ScanStart0514( ) ;
               while ( RcdFound14 != 0 )
               {
                  init_level_properties14( ) ;
                  getByPrimaryKey0514( ) ;
                  AddRow0514( ) ;
                  ScanNext0514( ) ;
               }
               ScanEnd0514( ) ;
               nBlankRcdCount14 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0514( ) ;
            standaloneModal0514( ) ;
            sMode14 = Gx_mode;
            while ( nGXsfl_128_idx < nRC_GXsfl_128 )
            {
               bGXsfl_128_Refreshing = true;
               ReadRow0514( ) ;
               edtLocalidadId_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADID_"+sGXsfl_128_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), !bGXsfl_128_Refreshing);
               edtLocalidadNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADNOMBRE_"+sGXsfl_128_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtLocalidadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadNombre_Enabled), 5, 0), !bGXsfl_128_Refreshing);
               edtLocalidadCapacidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADCAPACIDAD_"+sGXsfl_128_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtLocalidadCapacidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0), !bGXsfl_128_Refreshing);
               edtLocalidadPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADPRECIO_"+sGXsfl_128_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtLocalidadPrecio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadPrecio_Enabled), 5, 0), !bGXsfl_128_Refreshing);
               edtLocalidadesVendidas_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADESVENDIDAS_"+sGXsfl_128_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtLocalidadesVendidas_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0), !bGXsfl_128_Refreshing);
               edtLocalidadesDisponibles_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADESDISPONIBLES_"+sGXsfl_128_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtLocalidadesDisponibles_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0), !bGXsfl_128_Refreshing);
               if ( ( nRcdExists_14 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0514( ) ;
               }
               SendRow0514( ) ;
               bGXsfl_128_Refreshing = false;
            }
            Gx_mode = sMode14;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount14 = 5;
            nRcdExists_14 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart0514( ) ;
               while ( RcdFound14 != 0 )
               {
                  sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx+1), 4, 0), 4, "0");
                  SubsflControlProps_12814( ) ;
                  init_level_properties14( ) ;
                  standaloneNotModal0514( ) ;
                  getByPrimaryKey0514( ) ;
                  standaloneModal0514( ) ;
                  AddRow0514( ) ;
                  ScanNext0514( ) ;
               }
               ScanEnd0514( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ! IsDsp( ) && ! IsDlt( ) )
         {
            sMode14 = Gx_mode;
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx+1), 4, 0), 4, "0");
            SubsflControlProps_12814( ) ;
            InitAll0514( ) ;
            init_level_properties14( ) ;
            nRcdExists_14 = 0;
            nIsMod_14 = 0;
            nRcdDeleted_14 = 0;
            nBlankRcdCount14 = (short)(nBlankRcdUsr14+nBlankRcdCount14);
            fRowAdded = 0;
            while ( nBlankRcdCount14 > 0 )
            {
               standaloneNotModal0514( ) ;
               standaloneModal0514( ) ;
               AddRow0514( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtLocalidadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount14 = (short)(nBlankRcdCount14-1);
            }
            Gx_mode = sMode14;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         /* Restore parent mode. */
         Gx_mode = sMode14;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         sStyleString = "";
         context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
         context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", Grid1Container);
         if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'/>") ;
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
         E11052 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read saved values. */
               Z34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "Z34EspectaculoId"), ".", ","));
               Z35EspectaculoNombre = cgiGet( "Z35EspectaculoNombre");
               Z36EspectaculoFecha = context.localUtil.CToD( cgiGet( "Z36EspectaculoFecha"), 0);
               Z8LugarId = (short)(context.localUtil.CToN( cgiGet( "Z8LugarId"), ".", ","));
               Z6TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( "Z6TipoEspectaculoId"), ".", ","));
               Z19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( "Z19EspectaculoPaisId"), ".", ","));
               Z29LugarPaisId = (short)(context.localUtil.CToN( cgiGet( "Z29LugarPaisId"), ".", ","));
               Z22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( "Z22EspectaculoCiudadId"), ".", ","));
               Z32LugarCiudadId = (short)(context.localUtil.CToN( cgiGet( "Z32LugarCiudadId"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               nRC_GXsfl_128 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_128"), ".", ","));
               N6TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( "N6TipoEspectaculoId"), ".", ","));
               N19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( "N19EspectaculoPaisId"), ".", ","));
               N22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( "N22EspectaculoCiudadId"), ".", ","));
               N8LugarId = (short)(context.localUtil.CToN( cgiGet( "N8LugarId"), ".", ","));
               N29LugarPaisId = (short)(context.localUtil.CToN( cgiGet( "N29LugarPaisId"), ".", ","));
               N32LugarCiudadId = (short)(context.localUtil.CToN( cgiGet( "N32LugarCiudadId"), ".", ","));
               AV19EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "vESPECTACULOID"), ".", ","));
               AV11Insert_TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_TIPOESPECTACULOID"), ".", ","));
               AV12Insert_EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ESPECTACULOPAISID"), ".", ","));
               AV13Insert_EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_ESPECTACULOCIUDADID"), ".", ","));
               AV14Insert_LugarId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_LUGARID"), ".", ","));
               AV15Insert_LugarPaisId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_LUGARPAISID"), ".", ","));
               AV16Insert_LugarCiudadId = (short)(context.localUtil.CToN( cgiGet( "vINSERT_LUGARCIUDADID"), ".", ","));
               A40001LugarFoto_GXI = cgiGet( "LUGARFOTO_GXI");
               A40000EspectaculoPaisBandera_GXI = cgiGet( "ESPECTACULOPAISBANDERA_GXI");
               A40002LugarPaisBandera_GXI = cgiGet( "LUGARPAISBANDERA_GXI");
               AV20Pgmname = cgiGet( "vPGMNAME");
               Gx_mode = cgiGet( "vMODE");
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESPECTACULOID");
                  AnyError = 1;
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A34EspectaculoId = 0;
                  AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               }
               else
               {
                  A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                  AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               }
               A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
               AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
               if ( context.localUtil.VCDate( cgiGet( edtEspectaculoFecha_Internalname), 1) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Espectaculo Fecha"}), 1, "ESPECTACULOFECHA");
                  AnyError = 1;
                  GX_FocusControl = edtEspectaculoFecha_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A36EspectaculoFecha = DateTime.MinValue;
                  AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               }
               else
               {
                  A36EspectaculoFecha = context.localUtil.CToD( cgiGet( edtEspectaculoFecha_Internalname), 1);
                  AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtTipoEspectaculoId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTipoEspectaculoId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "TIPOESPECTACULOID");
                  AnyError = 1;
                  GX_FocusControl = edtTipoEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A6TipoEspectaculoId = 0;
                  AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
               }
               else
               {
                  A6TipoEspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtTipoEspectaculoId_Internalname), ".", ","));
                  AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
               }
               A7TipoEspectaculoNombre = cgiGet( edtTipoEspectaculoNombre_Internalname);
               AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESPECTACULOPAISID");
                  AnyError = 1;
                  GX_FocusControl = edtEspectaculoPaisId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19EspectaculoPaisId = 0;
                  AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
               }
               else
               {
                  A19EspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoPaisId_Internalname), ".", ","));
                  AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
               }
               A20EspectaculoPaisNombre = cgiGet( edtEspectaculoPaisNombre_Internalname);
               AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
               A21EspectaculoPaisBandera = cgiGet( imgEspectaculoPaisBandera_Internalname);
               AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
               if ( ( ( context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "ESPECTACULOCIUDADID");
                  AnyError = 1;
                  GX_FocusControl = edtEspectaculoCiudadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A22EspectaculoCiudadId = 0;
                  AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
               }
               else
               {
                  A22EspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoCiudadId_Internalname), ".", ","));
                  AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
               }
               A23EspectaculoCiudadNombre = cgiGet( edtEspectaculoCiudadNombre_Internalname);
               AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
               if ( ( ( context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LUGARID");
                  AnyError = 1;
                  GX_FocusControl = edtLugarId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A8LugarId = 0;
                  AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               }
               else
               {
                  A8LugarId = (short)(context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ","));
                  AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
               }
               A9LugarNombre = cgiGet( edtLugarNombre_Internalname);
               AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
               A10LugarFoto = cgiGet( imgLugarFoto_Internalname);
               AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
               if ( ( ( context.localUtil.CToN( cgiGet( edtLugarPaisId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLugarPaisId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LUGARPAISID");
                  AnyError = 1;
                  GX_FocusControl = edtLugarPaisId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A29LugarPaisId = 0;
                  AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
               }
               else
               {
                  A29LugarPaisId = (short)(context.localUtil.CToN( cgiGet( edtLugarPaisId_Internalname), ".", ","));
                  AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
               }
               A30LugarPaisNombre = cgiGet( edtLugarPaisNombre_Internalname);
               AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
               A31LugarPaisBandera = cgiGet( imgLugarPaisBandera_Internalname);
               AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
               if ( ( ( context.localUtil.CToN( cgiGet( edtLugarCiudadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLugarCiudadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "LUGARCIUDADID");
                  AnyError = 1;
                  GX_FocusControl = edtLugarCiudadId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A32LugarCiudadId = 0;
                  AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
               }
               else
               {
                  A32LugarCiudadId = (short)(context.localUtil.CToN( cgiGet( edtLugarCiudadId_Internalname), ".", ","));
                  AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
               }
               A33LugarCiudadNombre = cgiGet( edtLugarCiudadNombre_Internalname);
               AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               getMultimediaValue(imgEspectaculoPaisBandera_Internalname, ref  A21EspectaculoPaisBandera, ref  A40000EspectaculoPaisBandera_GXI);
               getMultimediaValue(imgLugarFoto_Internalname, ref  A10LugarFoto, ref  A40001LugarFoto_GXI);
               getMultimediaValue(imgLugarPaisBandera_Internalname, ref  A31LugarPaisBandera, ref  A40002LugarPaisBandera_GXI);
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               forbiddenHiddens = new GXProperties();
               forbiddenHiddens.Add("hshsalt", "hsh"+"Espectaculo");
               forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A34EspectaculoId != Z34EspectaculoId ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
               {
                  GXUtil.WriteLog("espectaculo:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
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
                  A34EspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
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
                     sMode7 = Gx_mode;
                     Gx_mode = "UPD";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode7;
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( ! IsIns( ) )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound7 == 1 )
                     {
                        if ( IsDlt( ) )
                        {
                           /* Confirm record */
                           CONFIRM_050( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtn_enter_Internalname;
                              AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "ESPECTACULOID");
                        AnyError = 1;
                        GX_FocusControl = edtEspectaculoId_Internalname;
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
                           E11052 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12052 ();
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
            E12052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( IsIns( )  )
            {
               /* Clear variables for new insertion. */
               InitAll057( ) ;
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
            DisableAttributes057( ) ;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate057( ) ;
         if ( AnyError == 0 )
         {
            if ( IsDlt( ) )
            {
               OnDeleteControls057( ) ;
            }
            else
            {
               CheckExtendedTable057( ) ;
               CloseExtendedTableCursors057( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode7 = Gx_mode;
            CONFIRM_0514( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode7;
               AssignAttri("", false, "Gx_mode", Gx_mode);
               AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
               IsConfirmed = 1;
               AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
            }
            /* Restore parent mode. */
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
      }

      protected void CONFIRM_0515( )
      {
         nGXsfl_171_idx = 0;
         while ( nGXsfl_171_idx < nRC_GXsfl_171 )
         {
            ReadRow0515( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               GetKey0515( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  if ( RcdFound15 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0515( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0515( ) ;
                        CloseExtendedTableCursors0515( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                           AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtLocalidadId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( nRcdDeleted_15 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0515( ) ;
                        Load0515( ) ;
                        BeforeValidate0515( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0515( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_15 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0515( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0515( ) ;
                              CloseExtendedTableCursors0515( ) ;
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
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtLocalidadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSectorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSectorNombre_Internalname, StringUtil.RTrim( A18SectorNombre)) ;
            ChangePostValue( "ZT_"+"Z17SectorId_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18SectorNombre_"+sGXsfl_171_idx, StringUtil.RTrim( Z18SectorNombre)) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ".", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "SECTORID_"+sGXsfl_171_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SECTORNOMBRE_"+sGXsfl_171_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void CONFIRM_0514( )
      {
         nGXsfl_128_idx = 0;
         while ( nGXsfl_128_idx < nRC_GXsfl_128 )
         {
            ReadRow0514( ) ;
            if ( ( nRcdExists_14 != 0 ) || ( nIsMod_14 != 0 ) )
            {
               GetKey0514( ) ;
               if ( ( nRcdExists_14 == 0 ) && ( nRcdDeleted_14 == 0 ) )
               {
                  if ( RcdFound14 == 0 )
                  {
                     Gx_mode = "INS";
                     AssignAttri("", false, "Gx_mode", Gx_mode);
                     AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     BeforeValidate0514( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0514( ) ;
                        CloseExtendedTableCursors0514( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Save parent mode. */
                           sMode14 = Gx_mode;
                           CONFIRM_0515( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Restore parent mode. */
                              Gx_mode = sMode14;
                              AssignAttri("", false, "Gx_mode", Gx_mode);
                              AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                              IsConfirmed = 1;
                              AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                           }
                           /* Restore parent mode. */
                           Gx_mode = sMode14;
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        }
                     }
                  }
                  else
                  {
                     GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, GXCCtl);
                     AnyError = 1;
                     GX_FocusControl = edtLocalidadId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound14 != 0 )
                  {
                     if ( nRcdDeleted_14 != 0 )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        getByPrimaryKey0514( ) ;
                        Load0514( ) ;
                        BeforeValidate0514( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0514( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_14 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           BeforeValidate0514( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0514( ) ;
                              CloseExtendedTableCursors0514( ) ;
                              if ( AnyError == 0 )
                              {
                                 /* Save parent mode. */
                                 sMode14 = Gx_mode;
                                 CONFIRM_0515( ) ;
                                 if ( AnyError == 0 )
                                 {
                                    /* Restore parent mode. */
                                    Gx_mode = sMode14;
                                    AssignAttri("", false, "Gx_mode", Gx_mode);
                                    AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                                    IsConfirmed = 1;
                                    AssignAttri("", false, "IsConfirmed", StringUtil.LTrimStr( (decimal)(IsConfirmed), 4, 0));
                                 }
                                 /* Restore parent mode. */
                                 Gx_mode = sMode14;
                                 AssignAttri("", false, "Gx_mode", Gx_mode);
                                 AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_14 == 0 )
                     {
                        GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtLocalidadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtLocalidadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", ""))) ;
            ChangePostValue( edtLocalidadNombre_Internalname, StringUtil.RTrim( A12LocalidadNombre)) ;
            ChangePostValue( edtLocalidadCapacidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", ""))) ;
            ChangePostValue( edtLocalidadPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", ""))) ;
            ChangePostValue( edtLocalidadesVendidas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", ""))) ;
            ChangePostValue( edtLocalidadesDisponibles_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11LocalidadId_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11LocalidadId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z12LocalidadNombre_"+sGXsfl_128_idx, StringUtil.RTrim( Z12LocalidadNombre)) ;
            ChangePostValue( "ZT_"+"Z13LocalidadCapacidad_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13LocalidadCapacidad), 5, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z14LocalidadPrecio_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z14LocalidadPrecio, 9, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z15LocalidadesVendidas_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15LocalidadesVendidas), 5, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z16LocalidadesDisponibles_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16LocalidadesDisponibles), 5, 0, ".", ""))) ;
            ChangePostValue( "nRC_GXsfl_171_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_171), 8, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_14_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_14), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_14_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_14), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_14_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_14), 4, 0, ".", ""))) ;
            if ( nIsMod_14 != 0 )
            {
               ChangePostValue( "LOCALIDADID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADNOMBRE_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADCAPACIDAD_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADPRECIO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADESVENDIDAS_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADESDISPONIBLES_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption050( )
      {
      }

      protected void E11052( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV20Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV20Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV9TrnContext.FromXml(AV10WebSession.Get("TrnContext"), null, "TransactionContext", "GXObligatorio1");
         AV11Insert_TipoEspectaculoId = 0;
         AssignAttri("", false, "AV11Insert_TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(AV11Insert_TipoEspectaculoId), 4, 0));
         AV12Insert_EspectaculoPaisId = 0;
         AssignAttri("", false, "AV12Insert_EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(AV12Insert_EspectaculoPaisId), 4, 0));
         AV13Insert_EspectaculoCiudadId = 0;
         AssignAttri("", false, "AV13Insert_EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(AV13Insert_EspectaculoCiudadId), 4, 0));
         AV14Insert_LugarId = 0;
         AssignAttri("", false, "AV14Insert_LugarId", StringUtil.LTrimStr( (decimal)(AV14Insert_LugarId), 4, 0));
         AV15Insert_LugarPaisId = 0;
         AssignAttri("", false, "AV15Insert_LugarPaisId", StringUtil.LTrimStr( (decimal)(AV15Insert_LugarPaisId), 4, 0));
         AV16Insert_LugarCiudadId = 0;
         AssignAttri("", false, "AV16Insert_LugarCiudadId", StringUtil.LTrimStr( (decimal)(AV16Insert_LugarCiudadId), 4, 0));
         if ( ( StringUtil.StrCmp(AV9TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            AssignAttri("", false, "AV21GXV1", StringUtil.LTrimStr( (decimal)(AV21GXV1), 8, 0));
            while ( AV21GXV1 <= AV9TrnContext.gxTpr_Attributes.Count )
            {
               AV18TrnContextAtt = ((SdtTransactionContext_Attribute)AV9TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV18TrnContextAtt.gxTpr_Attributename, "TipoEspectaculoId") == 0 )
               {
                  AV11Insert_TipoEspectaculoId = (short)(NumberUtil.Val( AV18TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV11Insert_TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(AV11Insert_TipoEspectaculoId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV18TrnContextAtt.gxTpr_Attributename, "EspectaculoPaisId") == 0 )
               {
                  AV12Insert_EspectaculoPaisId = (short)(NumberUtil.Val( AV18TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV12Insert_EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(AV12Insert_EspectaculoPaisId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV18TrnContextAtt.gxTpr_Attributename, "EspectaculoCiudadId") == 0 )
               {
                  AV13Insert_EspectaculoCiudadId = (short)(NumberUtil.Val( AV18TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV13Insert_EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(AV13Insert_EspectaculoCiudadId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV18TrnContextAtt.gxTpr_Attributename, "LugarId") == 0 )
               {
                  AV14Insert_LugarId = (short)(NumberUtil.Val( AV18TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV14Insert_LugarId", StringUtil.LTrimStr( (decimal)(AV14Insert_LugarId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV18TrnContextAtt.gxTpr_Attributename, "LugarPaisId") == 0 )
               {
                  AV15Insert_LugarPaisId = (short)(NumberUtil.Val( AV18TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV15Insert_LugarPaisId", StringUtil.LTrimStr( (decimal)(AV15Insert_LugarPaisId), 4, 0));
               }
               else if ( StringUtil.StrCmp(AV18TrnContextAtt.gxTpr_Attributename, "LugarCiudadId") == 0 )
               {
                  AV16Insert_LugarCiudadId = (short)(NumberUtil.Val( AV18TrnContextAtt.gxTpr_Attributevalue, "."));
                  AssignAttri("", false, "AV16Insert_LugarCiudadId", StringUtil.LTrimStr( (decimal)(AV16Insert_LugarCiudadId), 4, 0));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
               AssignAttri("", false, "AV21GXV1", StringUtil.LTrimStr( (decimal)(AV21GXV1), 8, 0));
            }
         }
      }

      protected void E12052( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV9TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("wwespectaculo.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM057( short GX_JID )
      {
         if ( ( GX_JID == 25 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z35EspectaculoNombre = T00057_A35EspectaculoNombre[0];
               Z36EspectaculoFecha = T00057_A36EspectaculoFecha[0];
               Z8LugarId = T00057_A8LugarId[0];
               Z6TipoEspectaculoId = T00057_A6TipoEspectaculoId[0];
               Z19EspectaculoPaisId = T00057_A19EspectaculoPaisId[0];
               Z29LugarPaisId = T00057_A29LugarPaisId[0];
               Z22EspectaculoCiudadId = T00057_A22EspectaculoCiudadId[0];
               Z32LugarCiudadId = T00057_A32LugarCiudadId[0];
            }
            else
            {
               Z35EspectaculoNombre = A35EspectaculoNombre;
               Z36EspectaculoFecha = A36EspectaculoFecha;
               Z8LugarId = A8LugarId;
               Z6TipoEspectaculoId = A6TipoEspectaculoId;
               Z19EspectaculoPaisId = A19EspectaculoPaisId;
               Z29LugarPaisId = A29LugarPaisId;
               Z22EspectaculoCiudadId = A22EspectaculoCiudadId;
               Z32LugarCiudadId = A32LugarCiudadId;
            }
         }
         if ( GX_JID == -25 )
         {
            Z34EspectaculoId = A34EspectaculoId;
            Z35EspectaculoNombre = A35EspectaculoNombre;
            Z36EspectaculoFecha = A36EspectaculoFecha;
            Z8LugarId = A8LugarId;
            Z6TipoEspectaculoId = A6TipoEspectaculoId;
            Z19EspectaculoPaisId = A19EspectaculoPaisId;
            Z29LugarPaisId = A29LugarPaisId;
            Z22EspectaculoCiudadId = A22EspectaculoCiudadId;
            Z32LugarCiudadId = A32LugarCiudadId;
            Z7TipoEspectaculoNombre = A7TipoEspectaculoNombre;
            Z20EspectaculoPaisNombre = A20EspectaculoPaisNombre;
            Z21EspectaculoPaisBandera = A21EspectaculoPaisBandera;
            Z40000EspectaculoPaisBandera_GXI = A40000EspectaculoPaisBandera_GXI;
            Z23EspectaculoCiudadNombre = A23EspectaculoCiudadNombre;
            Z9LugarNombre = A9LugarNombre;
            Z10LugarFoto = A10LugarFoto;
            Z40001LugarFoto_GXI = A40001LugarFoto_GXI;
            Z30LugarPaisNombre = A30LugarPaisNombre;
            Z31LugarPaisBandera = A31LugarPaisBandera;
            Z40002LugarPaisBandera_GXI = A40002LugarPaisBandera_GXI;
            Z33LugarCiudadNombre = A33LugarCiudadNombre;
         }
      }

      protected void standaloneNotModal( )
      {
         imgprompt_6_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00b0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"TIPOESPECTACULOID"+"'), id:'"+"TIPOESPECTACULOID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESPECTACULOPAISID"+"'), id:'"+"ESPECTACULOPAISID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_22_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESPECTACULOPAISID"+"'), id:'"+"ESPECTACULOPAISID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"ESPECTACULOCIUDADID"+"'), id:'"+"ESPECTACULOCIUDADID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_8_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0040.aspx"+"',["+"{Ctrl:gx.dom.el('"+"LUGARID"+"'), id:'"+"LUGARID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_29_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0010.aspx"+"',["+"{Ctrl:gx.dom.el('"+"LUGARPAISID"+"'), id:'"+"LUGARPAISID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         imgprompt_32_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0021.aspx"+"',["+"{Ctrl:gx.dom.el('"+"LUGARPAISID"+"'), id:'"+"LUGARPAISID"+"'"+",IOType:'in'}"+","+"{Ctrl:gx.dom.el('"+"LUGARCIUDADID"+"'), id:'"+"LUGARCIUDADID"+"'"+",IOType:'out'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         bttBtn_delete_Enabled = 0;
         AssignProp("", false, bttBtn_delete_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(bttBtn_delete_Enabled), 5, 0), true);
         if ( ! (0==AV19EspectaculoId) )
         {
            A34EspectaculoId = AV19EspectaculoId;
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         }
         if ( ! (0==AV19EspectaculoId) )
         {
            edtEspectaculoId_Enabled = 0;
            AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         }
         else
         {
            edtEspectaculoId_Enabled = 1;
            AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         }
         if ( ! (0==AV19EspectaculoId) )
         {
            edtEspectaculoId_Enabled = 0;
            AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_TipoEspectaculoId) )
         {
            edtTipoEspectaculoId_Enabled = 0;
            AssignProp("", false, edtTipoEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTipoEspectaculoId_Enabled), 5, 0), true);
         }
         else
         {
            edtTipoEspectaculoId_Enabled = 1;
            AssignProp("", false, edtTipoEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTipoEspectaculoId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_EspectaculoPaisId) )
         {
            edtEspectaculoPaisId_Enabled = 0;
            AssignProp("", false, edtEspectaculoPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoPaisId_Enabled), 5, 0), true);
         }
         else
         {
            edtEspectaculoPaisId_Enabled = 1;
            AssignProp("", false, edtEspectaculoPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoPaisId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_EspectaculoCiudadId) )
         {
            edtEspectaculoCiudadId_Enabled = 0;
            AssignProp("", false, edtEspectaculoCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoCiudadId_Enabled), 5, 0), true);
         }
         else
         {
            edtEspectaculoCiudadId_Enabled = 1;
            AssignProp("", false, edtEspectaculoCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoCiudadId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_LugarId) )
         {
            edtLugarId_Enabled = 0;
            AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         }
         else
         {
            edtLugarId_Enabled = 1;
            AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_LugarPaisId) )
         {
            edtLugarPaisId_Enabled = 0;
            AssignProp("", false, edtLugarPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarPaisId_Enabled), 5, 0), true);
         }
         else
         {
            edtLugarPaisId_Enabled = 1;
            AssignProp("", false, edtLugarPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarPaisId_Enabled), 5, 0), true);
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV16Insert_LugarCiudadId) )
         {
            edtLugarCiudadId_Enabled = 0;
            AssignProp("", false, edtLugarCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarCiudadId_Enabled), 5, 0), true);
         }
         else
         {
            edtLugarCiudadId_Enabled = 1;
            AssignProp("", false, edtLugarCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarCiudadId_Enabled), 5, 0), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV16Insert_LugarCiudadId) )
         {
            A32LugarCiudadId = AV16Insert_LugarCiudadId;
            AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV15Insert_LugarPaisId) )
         {
            A29LugarPaisId = AV15Insert_LugarPaisId;
            AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV14Insert_LugarId) )
         {
            A8LugarId = AV14Insert_LugarId;
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_EspectaculoCiudadId) )
         {
            A22EspectaculoCiudadId = AV13Insert_EspectaculoCiudadId;
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV12Insert_EspectaculoPaisId) )
         {
            A19EspectaculoPaisId = AV12Insert_EspectaculoPaisId;
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV11Insert_TipoEspectaculoId) )
         {
            A6TipoEspectaculoId = AV11Insert_TipoEspectaculoId;
            AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
         }
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
            AV20Pgmname = "Espectaculo";
            AssignAttri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T000511 */
            pr_default.execute(9, new Object[] {A29LugarPaisId});
            A30LugarPaisNombre = T000511_A30LugarPaisNombre[0];
            AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
            A40002LugarPaisBandera_GXI = T000511_A40002LugarPaisBandera_GXI[0];
            AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
            n40002LugarPaisBandera_GXI = T000511_n40002LugarPaisBandera_GXI[0];
            A31LugarPaisBandera = T000511_A31LugarPaisBandera[0];
            AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
            pr_default.close(9);
            /* Using cursor T000513 */
            pr_default.execute(11, new Object[] {A29LugarPaisId, A32LugarCiudadId});
            A33LugarCiudadNombre = T000513_A33LugarCiudadNombre[0];
            AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
            pr_default.close(11);
            /* Using cursor T00058 */
            pr_default.execute(6, new Object[] {A8LugarId});
            A9LugarNombre = T00058_A9LugarNombre[0];
            AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
            A40001LugarFoto_GXI = T00058_A40001LugarFoto_GXI[0];
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A10LugarFoto = T00058_A10LugarFoto[0];
            AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            pr_default.close(6);
            /* Using cursor T000510 */
            pr_default.execute(8, new Object[] {A19EspectaculoPaisId});
            A20EspectaculoPaisNombre = T000510_A20EspectaculoPaisNombre[0];
            AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A40000EspectaculoPaisBandera_GXI = T000510_A40000EspectaculoPaisBandera_GXI[0];
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            n40000EspectaculoPaisBandera_GXI = T000510_n40000EspectaculoPaisBandera_GXI[0];
            A21EspectaculoPaisBandera = T000510_A21EspectaculoPaisBandera[0];
            AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            pr_default.close(8);
            /* Using cursor T000512 */
            pr_default.execute(10, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
            A23EspectaculoCiudadNombre = T000512_A23EspectaculoCiudadNombre[0];
            AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            pr_default.close(10);
            /* Using cursor T00059 */
            pr_default.execute(7, new Object[] {A6TipoEspectaculoId});
            A7TipoEspectaculoNombre = T00059_A7TipoEspectaculoNombre[0];
            AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
            pr_default.close(7);
         }
      }

      protected void Load057( )
      {
         /* Using cursor T000514 */
         pr_default.execute(12, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound7 = 1;
            A35EspectaculoNombre = T000514_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T000514_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A7TipoEspectaculoNombre = T000514_A7TipoEspectaculoNombre[0];
            AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
            A20EspectaculoPaisNombre = T000514_A20EspectaculoPaisNombre[0];
            AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A40000EspectaculoPaisBandera_GXI = T000514_A40000EspectaculoPaisBandera_GXI[0];
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            n40000EspectaculoPaisBandera_GXI = T000514_n40000EspectaculoPaisBandera_GXI[0];
            A23EspectaculoCiudadNombre = T000514_A23EspectaculoCiudadNombre[0];
            AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            A9LugarNombre = T000514_A9LugarNombre[0];
            AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
            A40001LugarFoto_GXI = T000514_A40001LugarFoto_GXI[0];
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A30LugarPaisNombre = T000514_A30LugarPaisNombre[0];
            AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
            A40002LugarPaisBandera_GXI = T000514_A40002LugarPaisBandera_GXI[0];
            AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
            n40002LugarPaisBandera_GXI = T000514_n40002LugarPaisBandera_GXI[0];
            A33LugarCiudadNombre = T000514_A33LugarCiudadNombre[0];
            AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
            A8LugarId = T000514_A8LugarId[0];
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            A6TipoEspectaculoId = T000514_A6TipoEspectaculoId[0];
            AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
            A19EspectaculoPaisId = T000514_A19EspectaculoPaisId[0];
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A29LugarPaisId = T000514_A29LugarPaisId[0];
            AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
            A22EspectaculoCiudadId = T000514_A22EspectaculoCiudadId[0];
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            A32LugarCiudadId = T000514_A32LugarCiudadId[0];
            AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
            A21EspectaculoPaisBandera = T000514_A21EspectaculoPaisBandera[0];
            AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            A10LugarFoto = T000514_A10LugarFoto[0];
            AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A31LugarPaisBandera = T000514_A31LugarPaisBandera[0];
            AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
            ZM057( -25) ;
         }
         pr_default.close(12);
         OnLoadActions057( ) ;
      }

      protected void OnLoadActions057( )
      {
         AV20Pgmname = "Espectaculo";
         AssignAttri("", false, "AV20Pgmname", AV20Pgmname);
      }

      protected void CheckExtendedTable057( )
      {
         nIsDirty_7 = 0;
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV20Pgmname = "Espectaculo";
         AssignAttri("", false, "AV20Pgmname", AV20Pgmname);
         if ( ! ( (DateTime.MinValue==A36EspectaculoFecha) || ( A36EspectaculoFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Espectaculo Fecha is out of range", "OutOfRange", 1, "ESPECTACULOFECHA");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoFecha_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         /* Using cursor T00059 */
         pr_default.execute(7, new Object[] {A6TipoEspectaculoId});
         if ( (pr_default.getStatus(7) == 101) )
         {
            GX_msglist.addItem("No matching 'Tipo Espectaculo'.", "ForeignKeyNotFound", 1, "TIPOESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtTipoEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A7TipoEspectaculoNombre = T00059_A7TipoEspectaculoNombre[0];
         AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
         pr_default.close(7);
         /* Using cursor T000510 */
         pr_default.execute(8, new Object[] {A19EspectaculoPaisId});
         if ( (pr_default.getStatus(8) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "ESPECTACULOPAISID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A20EspectaculoPaisNombre = T000510_A20EspectaculoPaisNombre[0];
         AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
         A40000EspectaculoPaisBandera_GXI = T000510_A40000EspectaculoPaisBandera_GXI[0];
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         n40000EspectaculoPaisBandera_GXI = T000510_n40000EspectaculoPaisBandera_GXI[0];
         A21EspectaculoPaisBandera = T000510_A21EspectaculoPaisBandera[0];
         AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         pr_default.close(8);
         /* Using cursor T000512 */
         pr_default.execute(10, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
         if ( (pr_default.getStatus(10) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "ESPECTACULOPAISID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23EspectaculoCiudadNombre = T000512_A23EspectaculoCiudadNombre[0];
         AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
         pr_default.close(10);
         /* Using cursor T00058 */
         pr_default.execute(6, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar'.", "ForeignKeyNotFound", 1, "LUGARID");
            AnyError = 1;
            GX_FocusControl = edtLugarId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9LugarNombre = T00058_A9LugarNombre[0];
         AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
         A40001LugarFoto_GXI = T00058_A40001LugarFoto_GXI[0];
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         A10LugarFoto = T00058_A10LugarFoto[0];
         AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         pr_default.close(6);
         /* Using cursor T000511 */
         pr_default.execute(9, new Object[] {A29LugarPaisId});
         if ( (pr_default.getStatus(9) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar Pais'.", "ForeignKeyNotFound", 1, "LUGARPAISID");
            AnyError = 1;
            GX_FocusControl = edtLugarPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A30LugarPaisNombre = T000511_A30LugarPaisNombre[0];
         AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
         A40002LugarPaisBandera_GXI = T000511_A40002LugarPaisBandera_GXI[0];
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
         n40002LugarPaisBandera_GXI = T000511_n40002LugarPaisBandera_GXI[0];
         A31LugarPaisBandera = T000511_A31LugarPaisBandera[0];
         AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
         pr_default.close(9);
         /* Using cursor T000513 */
         pr_default.execute(11, new Object[] {A29LugarPaisId, A32LugarCiudadId});
         if ( (pr_default.getStatus(11) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar Pais'.", "ForeignKeyNotFound", 1, "LUGARPAISID");
            AnyError = 1;
            GX_FocusControl = edtLugarPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A33LugarCiudadNombre = T000513_A33LugarCiudadNombre[0];
         AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
         pr_default.close(11);
      }

      protected void CloseExtendedTableCursors057( )
      {
         pr_default.close(7);
         pr_default.close(8);
         pr_default.close(10);
         pr_default.close(6);
         pr_default.close(9);
         pr_default.close(11);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_27( short A6TipoEspectaculoId )
      {
         /* Using cursor T000515 */
         pr_default.execute(13, new Object[] {A6TipoEspectaculoId});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("No matching 'Tipo Espectaculo'.", "ForeignKeyNotFound", 1, "TIPOESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtTipoEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A7TipoEspectaculoNombre = T000515_A7TipoEspectaculoNombre[0];
         AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A7TipoEspectaculoNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(13) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(13);
      }

      protected void gxLoad_28( short A19EspectaculoPaisId )
      {
         /* Using cursor T000516 */
         pr_default.execute(14, new Object[] {A19EspectaculoPaisId});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "ESPECTACULOPAISID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A20EspectaculoPaisNombre = T000516_A20EspectaculoPaisNombre[0];
         AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
         A40000EspectaculoPaisBandera_GXI = T000516_A40000EspectaculoPaisBandera_GXI[0];
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         n40000EspectaculoPaisBandera_GXI = T000516_n40000EspectaculoPaisBandera_GXI[0];
         A21EspectaculoPaisBandera = T000516_A21EspectaculoPaisBandera[0];
         AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A20EspectaculoPaisNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( A21EspectaculoPaisBandera)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40000EspectaculoPaisBandera_GXI)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(14) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(14);
      }

      protected void gxLoad_30( short A19EspectaculoPaisId ,
                                short A22EspectaculoCiudadId )
      {
         /* Using cursor T000517 */
         pr_default.execute(15, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
         if ( (pr_default.getStatus(15) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "ESPECTACULOPAISID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A23EspectaculoCiudadNombre = T000517_A23EspectaculoCiudadNombre[0];
         AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A23EspectaculoCiudadNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(15) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(15);
      }

      protected void gxLoad_26( short A8LugarId )
      {
         /* Using cursor T000518 */
         pr_default.execute(16, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(16) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar'.", "ForeignKeyNotFound", 1, "LUGARID");
            AnyError = 1;
            GX_FocusControl = edtLugarId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A9LugarNombre = T000518_A9LugarNombre[0];
         AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
         A40001LugarFoto_GXI = T000518_A40001LugarFoto_GXI[0];
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         A10LugarFoto = T000518_A10LugarFoto[0];
         AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A9LugarNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( A10LugarFoto)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40001LugarFoto_GXI)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(16) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(16);
      }

      protected void gxLoad_29( short A29LugarPaisId )
      {
         /* Using cursor T000519 */
         pr_default.execute(17, new Object[] {A29LugarPaisId});
         if ( (pr_default.getStatus(17) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar Pais'.", "ForeignKeyNotFound", 1, "LUGARPAISID");
            AnyError = 1;
            GX_FocusControl = edtLugarPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A30LugarPaisNombre = T000519_A30LugarPaisNombre[0];
         AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
         A40002LugarPaisBandera_GXI = T000519_A40002LugarPaisBandera_GXI[0];
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
         n40002LugarPaisBandera_GXI = T000519_n40002LugarPaisBandera_GXI[0];
         A31LugarPaisBandera = T000519_A31LugarPaisBandera[0];
         AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A30LugarPaisNombre))+"\""+","+"\""+GXUtil.EncodeJSConstant( A31LugarPaisBandera)+"\""+","+"\""+GXUtil.EncodeJSConstant( A40002LugarPaisBandera_GXI)+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(17) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(17);
      }

      protected void gxLoad_31( short A29LugarPaisId ,
                                short A32LugarCiudadId )
      {
         /* Using cursor T000520 */
         pr_default.execute(18, new Object[] {A29LugarPaisId, A32LugarCiudadId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar Pais'.", "ForeignKeyNotFound", 1, "LUGARPAISID");
            AnyError = 1;
            GX_FocusControl = edtLugarPaisId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A33LugarCiudadNombre = T000520_A33LugarCiudadNombre[0];
         AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
         GxWebStd.set_html_headers( context, 0, "", "");
         AddString( "[[") ;
         AddString( "\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A33LugarCiudadNombre))+"\"") ;
         AddString( "]") ;
         if ( (pr_default.getStatus(18) == 101) )
         {
            AddString( ",") ;
            AddString( "101") ;
         }
         AddString( "]") ;
         pr_default.close(18);
      }

      protected void GetKey057( )
      {
         /* Using cursor T000521 */
         pr_default.execute(19, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(19) != 101) )
         {
            RcdFound7 = 1;
         }
         else
         {
            RcdFound7 = 0;
         }
         pr_default.close(19);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            ZM057( 25) ;
            RcdFound7 = 1;
            A34EspectaculoId = T00057_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            A35EspectaculoNombre = T00057_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            A36EspectaculoFecha = T00057_A36EspectaculoFecha[0];
            AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
            A8LugarId = T00057_A8LugarId[0];
            AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
            A6TipoEspectaculoId = T00057_A6TipoEspectaculoId[0];
            AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
            A19EspectaculoPaisId = T00057_A19EspectaculoPaisId[0];
            AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
            A29LugarPaisId = T00057_A29LugarPaisId[0];
            AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
            A22EspectaculoCiudadId = T00057_A22EspectaculoCiudadId[0];
            AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
            A32LugarCiudadId = T00057_A32LugarCiudadId[0];
            AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
            Z34EspectaculoId = A34EspectaculoId;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load057( ) ;
            if ( AnyError == 1 )
            {
               RcdFound7 = 0;
               InitializeNonKey057( ) ;
            }
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound7 = 0;
            InitializeNonKey057( ) ;
            sMode7 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode7;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(5);
      }

      protected void getEqualNoModal( )
      {
         GetKey057( ) ;
         if ( RcdFound7 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound7 = 0;
         /* Using cursor T000522 */
         pr_default.execute(20, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(20) != 101) )
         {
            while ( (pr_default.getStatus(20) != 101) && ( ( T000522_A34EspectaculoId[0] < A34EspectaculoId ) ) )
            {
               pr_default.readNext(20);
            }
            if ( (pr_default.getStatus(20) != 101) && ( ( T000522_A34EspectaculoId[0] > A34EspectaculoId ) ) )
            {
               A34EspectaculoId = T000522_A34EspectaculoId[0];
               AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(20);
      }

      protected void move_previous( )
      {
         RcdFound7 = 0;
         /* Using cursor T000523 */
         pr_default.execute(21, new Object[] {A34EspectaculoId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            while ( (pr_default.getStatus(21) != 101) && ( ( T000523_A34EspectaculoId[0] > A34EspectaculoId ) ) )
            {
               pr_default.readNext(21);
            }
            if ( (pr_default.getStatus(21) != 101) && ( ( T000523_A34EspectaculoId[0] < A34EspectaculoId ) ) )
            {
               A34EspectaculoId = T000523_A34EspectaculoId[0];
               AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
               RcdFound7 = 1;
            }
         }
         pr_default.close(21);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey057( ) ;
         if ( IsIns( ) )
         {
            /* Insert record */
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            Insert057( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound7 == 1 )
            {
               if ( A34EspectaculoId != Z34EspectaculoId )
               {
                  A34EspectaculoId = Z34EspectaculoId;
                  AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "ESPECTACULOID");
                  AnyError = 1;
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( IsDlt( ) )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update057( ) ;
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A34EspectaculoId != Z34EspectaculoId )
               {
                  /* Insert record */
                  GX_FocusControl = edtEspectaculoId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert057( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "ESPECTACULOID");
                     AnyError = 1;
                     GX_FocusControl = edtEspectaculoId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtEspectaculoId_Internalname;
                     AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert057( ) ;
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
         if ( A34EspectaculoId != Z34EspectaculoId )
         {
            A34EspectaculoId = Z34EspectaculoId;
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "ESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtEspectaculoId_Internalname;
            AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency057( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00056 */
            pr_default.execute(4, new Object[] {A34EspectaculoId});
            if ( (pr_default.getStatus(4) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Espectaculo"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(4) == 101) || ( StringUtil.StrCmp(Z35EspectaculoNombre, T00056_A35EspectaculoNombre[0]) != 0 ) || ( Z36EspectaculoFecha != T00056_A36EspectaculoFecha[0] ) || ( Z8LugarId != T00056_A8LugarId[0] ) || ( Z6TipoEspectaculoId != T00056_A6TipoEspectaculoId[0] ) || ( Z19EspectaculoPaisId != T00056_A19EspectaculoPaisId[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z29LugarPaisId != T00056_A29LugarPaisId[0] ) || ( Z22EspectaculoCiudadId != T00056_A22EspectaculoCiudadId[0] ) || ( Z32LugarCiudadId != T00056_A32LugarCiudadId[0] ) )
            {
               if ( StringUtil.StrCmp(Z35EspectaculoNombre, T00056_A35EspectaculoNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"EspectaculoNombre");
                  GXUtil.WriteLogRaw("Old: ",Z35EspectaculoNombre);
                  GXUtil.WriteLogRaw("Current: ",T00056_A35EspectaculoNombre[0]);
               }
               if ( Z36EspectaculoFecha != T00056_A36EspectaculoFecha[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"EspectaculoFecha");
                  GXUtil.WriteLogRaw("Old: ",Z36EspectaculoFecha);
                  GXUtil.WriteLogRaw("Current: ",T00056_A36EspectaculoFecha[0]);
               }
               if ( Z8LugarId != T00056_A8LugarId[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LugarId");
                  GXUtil.WriteLogRaw("Old: ",Z8LugarId);
                  GXUtil.WriteLogRaw("Current: ",T00056_A8LugarId[0]);
               }
               if ( Z6TipoEspectaculoId != T00056_A6TipoEspectaculoId[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"TipoEspectaculoId");
                  GXUtil.WriteLogRaw("Old: ",Z6TipoEspectaculoId);
                  GXUtil.WriteLogRaw("Current: ",T00056_A6TipoEspectaculoId[0]);
               }
               if ( Z19EspectaculoPaisId != T00056_A19EspectaculoPaisId[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"EspectaculoPaisId");
                  GXUtil.WriteLogRaw("Old: ",Z19EspectaculoPaisId);
                  GXUtil.WriteLogRaw("Current: ",T00056_A19EspectaculoPaisId[0]);
               }
               if ( Z29LugarPaisId != T00056_A29LugarPaisId[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LugarPaisId");
                  GXUtil.WriteLogRaw("Old: ",Z29LugarPaisId);
                  GXUtil.WriteLogRaw("Current: ",T00056_A29LugarPaisId[0]);
               }
               if ( Z22EspectaculoCiudadId != T00056_A22EspectaculoCiudadId[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"EspectaculoCiudadId");
                  GXUtil.WriteLogRaw("Old: ",Z22EspectaculoCiudadId);
                  GXUtil.WriteLogRaw("Current: ",T00056_A22EspectaculoCiudadId[0]);
               }
               if ( Z32LugarCiudadId != T00056_A32LugarCiudadId[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LugarCiudadId");
                  GXUtil.WriteLogRaw("Old: ",Z32LugarCiudadId);
                  GXUtil.WriteLogRaw("Current: ",T00056_A32LugarCiudadId[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Espectaculo"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert057( )
      {
         BeforeValidate057( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable057( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM057( 0) ;
            CheckOptimisticConcurrency057( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm057( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert057( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000524 */
                     pr_default.execute(22, new Object[] {A34EspectaculoId, A35EspectaculoNombre, A36EspectaculoFecha, A8LugarId, A6TipoEspectaculoId, A19EspectaculoPaisId, A29LugarPaisId, A22EspectaculoCiudadId, A32LugarCiudadId});
                     pr_default.close(22);
                     dsDefault.SmartCacheProvider.SetUpdated("Espectaculo") ;
                     if ( (pr_default.getStatus(22) == 1) )
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
                           ProcessLevel057( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                              ResetCaption050( ) ;
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
               Load057( ) ;
            }
            EndLevel057( ) ;
         }
         CloseExtendedTableCursors057( ) ;
      }

      protected void Update057( )
      {
         BeforeValidate057( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable057( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency057( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm057( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate057( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000525 */
                     pr_default.execute(23, new Object[] {A35EspectaculoNombre, A36EspectaculoFecha, A8LugarId, A6TipoEspectaculoId, A19EspectaculoPaisId, A29LugarPaisId, A22EspectaculoCiudadId, A32LugarCiudadId, A34EspectaculoId});
                     pr_default.close(23);
                     dsDefault.SmartCacheProvider.SetUpdated("Espectaculo") ;
                     if ( (pr_default.getStatus(23) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Espectaculo"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate057( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel057( ) ;
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
            EndLevel057( ) ;
         }
         CloseExtendedTableCursors057( ) ;
      }

      protected void DeferredUpdate057( )
      {
      }

      protected void delete( )
      {
         BeforeValidate057( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency057( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls057( ) ;
            AfterConfirm057( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete057( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000526 */
                  pr_default.execute(24, new Object[] {A34EspectaculoId});
                  pr_default.close(24);
                  dsDefault.SmartCacheProvider.SetUpdated("Espectaculo") ;
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
         sMode7 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel057( ) ;
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls057( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "Espectaculo";
            AssignAttri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T000527 */
            pr_default.execute(25, new Object[] {A6TipoEspectaculoId});
            A7TipoEspectaculoNombre = T000527_A7TipoEspectaculoNombre[0];
            AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
            pr_default.close(25);
            /* Using cursor T000528 */
            pr_default.execute(26, new Object[] {A19EspectaculoPaisId});
            A20EspectaculoPaisNombre = T000528_A20EspectaculoPaisNombre[0];
            AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
            A40000EspectaculoPaisBandera_GXI = T000528_A40000EspectaculoPaisBandera_GXI[0];
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            n40000EspectaculoPaisBandera_GXI = T000528_n40000EspectaculoPaisBandera_GXI[0];
            A21EspectaculoPaisBandera = T000528_A21EspectaculoPaisBandera[0];
            AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
            AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
            pr_default.close(26);
            /* Using cursor T000529 */
            pr_default.execute(27, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
            A23EspectaculoCiudadNombre = T000529_A23EspectaculoCiudadNombre[0];
            AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
            pr_default.close(27);
            /* Using cursor T000530 */
            pr_default.execute(28, new Object[] {A8LugarId});
            A9LugarNombre = T000530_A9LugarNombre[0];
            AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
            A40001LugarFoto_GXI = T000530_A40001LugarFoto_GXI[0];
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            A10LugarFoto = T000530_A10LugarFoto[0];
            AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
            AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
            AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
            pr_default.close(28);
            /* Using cursor T000531 */
            pr_default.execute(29, new Object[] {A29LugarPaisId});
            A30LugarPaisNombre = T000531_A30LugarPaisNombre[0];
            AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
            A40002LugarPaisBandera_GXI = T000531_A40002LugarPaisBandera_GXI[0];
            AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
            n40002LugarPaisBandera_GXI = T000531_n40002LugarPaisBandera_GXI[0];
            A31LugarPaisBandera = T000531_A31LugarPaisBandera[0];
            AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
            AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
            pr_default.close(29);
            /* Using cursor T000532 */
            pr_default.execute(30, new Object[] {A29LugarPaisId, A32LugarCiudadId});
            A33LugarCiudadNombre = T000532_A33LugarCiudadNombre[0];
            AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
            pr_default.close(30);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000533 */
            pr_default.execute(31, new Object[] {A34EspectaculoId});
            if ( (pr_default.getStatus(31) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Venta"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(31);
            /* Using cursor T000534 */
            pr_default.execute(32, new Object[] {A34EspectaculoId});
            if ( (pr_default.getStatus(32) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Localidad"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(32);
         }
      }

      protected void ProcessNestedLevel0514( )
      {
         nGXsfl_128_idx = 0;
         while ( nGXsfl_128_idx < nRC_GXsfl_128 )
         {
            ReadRow0514( ) ;
            if ( ( nRcdExists_14 != 0 ) || ( nIsMod_14 != 0 ) )
            {
               standaloneNotModal0514( ) ;
               GetKey0514( ) ;
               if ( ( nRcdExists_14 == 0 ) && ( nRcdDeleted_14 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0514( ) ;
               }
               else
               {
                  if ( RcdFound14 != 0 )
                  {
                     if ( ( nRcdDeleted_14 != 0 ) && ( nRcdExists_14 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0514( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_14 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0514( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_14 == 0 )
                     {
                        GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtLocalidadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtLocalidadId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", ""))) ;
            ChangePostValue( edtLocalidadNombre_Internalname, StringUtil.RTrim( A12LocalidadNombre)) ;
            ChangePostValue( edtLocalidadCapacidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", ""))) ;
            ChangePostValue( edtLocalidadPrecio_Internalname, StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", ""))) ;
            ChangePostValue( edtLocalidadesVendidas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", ""))) ;
            ChangePostValue( edtLocalidadesDisponibles_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z11LocalidadId_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11LocalidadId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z12LocalidadNombre_"+sGXsfl_128_idx, StringUtil.RTrim( Z12LocalidadNombre)) ;
            ChangePostValue( "ZT_"+"Z13LocalidadCapacidad_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13LocalidadCapacidad), 5, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z14LocalidadPrecio_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( Z14LocalidadPrecio, 9, 2, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z15LocalidadesVendidas_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15LocalidadesVendidas), 5, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z16LocalidadesDisponibles_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16LocalidadesDisponibles), 5, 0, ".", ""))) ;
            ChangePostValue( "nRC_GXsfl_171_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_171), 8, 0, ".", ""))) ;
            ChangePostValue( "nRcdDeleted_14_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_14), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_14_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_14), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_14_"+sGXsfl_128_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_14), 4, 0, ".", ""))) ;
            if ( nIsMod_14 != 0 )
            {
               ChangePostValue( "LOCALIDADID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADNOMBRE_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADCAPACIDAD_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADPRECIO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadPrecio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADESVENDIDAS_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LOCALIDADESDISPONIBLES_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0514( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_14 = 0;
         nIsMod_14 = 0;
         nRcdDeleted_14 = 0;
      }

      protected void ProcessLevel057( )
      {
         /* Save parent mode. */
         sMode7 = Gx_mode;
         ProcessNestedLevel0514( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode7;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel057( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(4);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete057( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(28);
            pr_default.close(25);
            pr_default.close(26);
            pr_default.close(29);
            pr_default.close(27);
            pr_default.close(30);
            context.CommitDataStores("espectaculo",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(3);
            pr_default.close(2);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(28);
            pr_default.close(25);
            pr_default.close(26);
            pr_default.close(29);
            pr_default.close(27);
            pr_default.close(30);
            context.RollbackDataStores("espectaculo",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart057( )
      {
         /* Scan By routine */
         /* Using cursor T000535 */
         pr_default.execute(33);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound7 = 1;
            A34EspectaculoId = T000535_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext057( )
      {
         /* Scan next routine */
         pr_default.readNext(33);
         RcdFound7 = 0;
         if ( (pr_default.getStatus(33) != 101) )
         {
            RcdFound7 = 1;
            A34EspectaculoId = T000535_A34EspectaculoId[0];
            AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         }
      }

      protected void ScanEnd057( )
      {
         pr_default.close(33);
      }

      protected void AfterConfirm057( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert057( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate057( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete057( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete057( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate057( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes057( )
      {
         edtEspectaculoId_Enabled = 0;
         AssignProp("", false, edtEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoId_Enabled), 5, 0), true);
         edtEspectaculoNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoNombre_Enabled), 5, 0), true);
         edtEspectaculoFecha_Enabled = 0;
         AssignProp("", false, edtEspectaculoFecha_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoFecha_Enabled), 5, 0), true);
         edtTipoEspectaculoId_Enabled = 0;
         AssignProp("", false, edtTipoEspectaculoId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTipoEspectaculoId_Enabled), 5, 0), true);
         edtTipoEspectaculoNombre_Enabled = 0;
         AssignProp("", false, edtTipoEspectaculoNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtTipoEspectaculoNombre_Enabled), 5, 0), true);
         edtEspectaculoPaisId_Enabled = 0;
         AssignProp("", false, edtEspectaculoPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoPaisId_Enabled), 5, 0), true);
         edtEspectaculoPaisNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoPaisNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoPaisNombre_Enabled), 5, 0), true);
         imgEspectaculoPaisBandera_Enabled = 0;
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgEspectaculoPaisBandera_Enabled), 5, 0), true);
         edtEspectaculoCiudadId_Enabled = 0;
         AssignProp("", false, edtEspectaculoCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoCiudadId_Enabled), 5, 0), true);
         edtEspectaculoCiudadNombre_Enabled = 0;
         AssignProp("", false, edtEspectaculoCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtEspectaculoCiudadNombre_Enabled), 5, 0), true);
         edtLugarId_Enabled = 0;
         AssignProp("", false, edtLugarId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarId_Enabled), 5, 0), true);
         edtLugarNombre_Enabled = 0;
         AssignProp("", false, edtLugarNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarNombre_Enabled), 5, 0), true);
         imgLugarFoto_Enabled = 0;
         AssignProp("", false, imgLugarFoto_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgLugarFoto_Enabled), 5, 0), true);
         edtLugarPaisId_Enabled = 0;
         AssignProp("", false, edtLugarPaisId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarPaisId_Enabled), 5, 0), true);
         edtLugarPaisNombre_Enabled = 0;
         AssignProp("", false, edtLugarPaisNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarPaisNombre_Enabled), 5, 0), true);
         imgLugarPaisBandera_Enabled = 0;
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(imgLugarPaisBandera_Enabled), 5, 0), true);
         edtLugarCiudadId_Enabled = 0;
         AssignProp("", false, edtLugarCiudadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarCiudadId_Enabled), 5, 0), true);
         edtLugarCiudadNombre_Enabled = 0;
         AssignProp("", false, edtLugarCiudadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLugarCiudadNombre_Enabled), 5, 0), true);
      }

      protected void ZM0514( short GX_JID )
      {
         if ( ( GX_JID == 32 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z12LocalidadNombre = T00055_A12LocalidadNombre[0];
               Z13LocalidadCapacidad = T00055_A13LocalidadCapacidad[0];
               Z14LocalidadPrecio = T00055_A14LocalidadPrecio[0];
               Z15LocalidadesVendidas = T00055_A15LocalidadesVendidas[0];
               Z16LocalidadesDisponibles = T00055_A16LocalidadesDisponibles[0];
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
         if ( GX_JID == -32 )
         {
            Z34EspectaculoId = A34EspectaculoId;
            Z11LocalidadId = A11LocalidadId;
            Z12LocalidadNombre = A12LocalidadNombre;
            Z13LocalidadCapacidad = A13LocalidadCapacidad;
            Z14LocalidadPrecio = A14LocalidadPrecio;
            Z15LocalidadesVendidas = A15LocalidadesVendidas;
            Z16LocalidadesDisponibles = A16LocalidadesDisponibles;
         }
      }

      protected void standaloneNotModal0514( )
      {
      }

      protected void standaloneModal0514( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtLocalidadId_Enabled = 0;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         }
         else
         {
            edtLocalidadId_Enabled = 1;
            AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         }
      }

      protected void Load0514( )
      {
         /* Using cursor T000536 */
         pr_default.execute(34, new Object[] {A34EspectaculoId, A11LocalidadId});
         if ( (pr_default.getStatus(34) != 101) )
         {
            RcdFound14 = 1;
            A12LocalidadNombre = T000536_A12LocalidadNombre[0];
            A13LocalidadCapacidad = T000536_A13LocalidadCapacidad[0];
            A14LocalidadPrecio = T000536_A14LocalidadPrecio[0];
            A15LocalidadesVendidas = T000536_A15LocalidadesVendidas[0];
            A16LocalidadesDisponibles = T000536_A16LocalidadesDisponibles[0];
            ZM0514( -32) ;
         }
         pr_default.close(34);
         OnLoadActions0514( ) ;
      }

      protected void OnLoadActions0514( )
      {
      }

      protected void CheckExtendedTable0514( )
      {
         nIsDirty_14 = 0;
         Gx_BScreen = 1;
         standaloneModal0514( ) ;
      }

      protected void CloseExtendedTableCursors0514( )
      {
      }

      protected void enableDisable0514( )
      {
      }

      protected void GetKey0514( )
      {
         /* Using cursor T000537 */
         pr_default.execute(35, new Object[] {A34EspectaculoId, A11LocalidadId});
         if ( (pr_default.getStatus(35) != 101) )
         {
            RcdFound14 = 1;
         }
         else
         {
            RcdFound14 = 0;
         }
         pr_default.close(35);
      }

      protected void getByPrimaryKey0514( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A34EspectaculoId, A11LocalidadId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            ZM0514( 32) ;
            RcdFound14 = 1;
            InitializeNonKey0514( ) ;
            A11LocalidadId = T00055_A11LocalidadId[0];
            A12LocalidadNombre = T00055_A12LocalidadNombre[0];
            A13LocalidadCapacidad = T00055_A13LocalidadCapacidad[0];
            A14LocalidadPrecio = T00055_A14LocalidadPrecio[0];
            A15LocalidadesVendidas = T00055_A15LocalidadesVendidas[0];
            A16LocalidadesDisponibles = T00055_A16LocalidadesDisponibles[0];
            Z34EspectaculoId = A34EspectaculoId;
            Z11LocalidadId = A11LocalidadId;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0514( ) ;
            Gx_mode = sMode14;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound14 = 0;
            InitializeNonKey0514( ) ;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0514( ) ;
            Gx_mode = sMode14;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes0514( ) ;
         }
         pr_default.close(3);
      }

      protected void CheckOptimisticConcurrency0514( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00054 */
            pr_default.execute(2, new Object[] {A34EspectaculoId, A11LocalidadId});
            if ( (pr_default.getStatus(2) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EspectaculoLocalidad"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(2) == 101) || ( StringUtil.StrCmp(Z12LocalidadNombre, T00054_A12LocalidadNombre[0]) != 0 ) || ( Z13LocalidadCapacidad != T00054_A13LocalidadCapacidad[0] ) || ( Z14LocalidadPrecio != T00054_A14LocalidadPrecio[0] ) || ( Z15LocalidadesVendidas != T00054_A15LocalidadesVendidas[0] ) || ( Z16LocalidadesDisponibles != T00054_A16LocalidadesDisponibles[0] ) )
            {
               if ( StringUtil.StrCmp(Z12LocalidadNombre, T00054_A12LocalidadNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LocalidadNombre");
                  GXUtil.WriteLogRaw("Old: ",Z12LocalidadNombre);
                  GXUtil.WriteLogRaw("Current: ",T00054_A12LocalidadNombre[0]);
               }
               if ( Z13LocalidadCapacidad != T00054_A13LocalidadCapacidad[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LocalidadCapacidad");
                  GXUtil.WriteLogRaw("Old: ",Z13LocalidadCapacidad);
                  GXUtil.WriteLogRaw("Current: ",T00054_A13LocalidadCapacidad[0]);
               }
               if ( Z14LocalidadPrecio != T00054_A14LocalidadPrecio[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LocalidadPrecio");
                  GXUtil.WriteLogRaw("Old: ",Z14LocalidadPrecio);
                  GXUtil.WriteLogRaw("Current: ",T00054_A14LocalidadPrecio[0]);
               }
               if ( Z15LocalidadesVendidas != T00054_A15LocalidadesVendidas[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LocalidadesVendidas");
                  GXUtil.WriteLogRaw("Old: ",Z15LocalidadesVendidas);
                  GXUtil.WriteLogRaw("Current: ",T00054_A15LocalidadesVendidas[0]);
               }
               if ( Z16LocalidadesDisponibles != T00054_A16LocalidadesDisponibles[0] )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"LocalidadesDisponibles");
                  GXUtil.WriteLogRaw("Old: ",Z16LocalidadesDisponibles);
                  GXUtil.WriteLogRaw("Current: ",T00054_A16LocalidadesDisponibles[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EspectaculoLocalidad"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0514( )
      {
         BeforeValidate0514( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0514( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0514( 0) ;
            CheckOptimisticConcurrency0514( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0514( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0514( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000538 */
                     pr_default.execute(36, new Object[] {A34EspectaculoId, A11LocalidadId, A12LocalidadNombre, A13LocalidadCapacidad, A14LocalidadPrecio, A15LocalidadesVendidas, A16LocalidadesDisponibles});
                     pr_default.close(36);
                     dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidad") ;
                     if ( (pr_default.getStatus(36) == 1) )
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
                           ProcessLevel0514( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
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
               Load0514( ) ;
            }
            EndLevel0514( ) ;
         }
         CloseExtendedTableCursors0514( ) ;
      }

      protected void Update0514( )
      {
         BeforeValidate0514( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0514( ) ;
         }
         if ( ( nIsMod_14 != 0 ) || ( nIsDirty_14 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency0514( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm0514( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate0514( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000539 */
                        pr_default.execute(37, new Object[] {A12LocalidadNombre, A13LocalidadCapacidad, A14LocalidadPrecio, A15LocalidadesVendidas, A16LocalidadesDisponibles, A34EspectaculoId, A11LocalidadId});
                        pr_default.close(37);
                        dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidad") ;
                        if ( (pr_default.getStatus(37) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EspectaculoLocalidad"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate0514( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              ProcessLevel0514( ) ;
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
               EndLevel0514( ) ;
            }
         }
         CloseExtendedTableCursors0514( ) ;
      }

      protected void DeferredUpdate0514( )
      {
      }

      protected void Delete0514( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0514( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0514( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0514( ) ;
            AfterConfirm0514( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0514( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0515( ) ;
                  while ( RcdFound15 != 0 )
                  {
                     getByPrimaryKey0515( ) ;
                     Delete0515( ) ;
                     ScanNext0515( ) ;
                  }
                  ScanEnd0515( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000540 */
                     pr_default.execute(38, new Object[] {A34EspectaculoId, A11LocalidadId});
                     pr_default.close(38);
                     dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidad") ;
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
         }
         sMode14 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0514( ) ;
         Gx_mode = sMode14;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0514( )
      {
         standaloneModal0514( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel0515( )
      {
         nGXsfl_171_idx = 0;
         while ( nGXsfl_171_idx < nRC_GXsfl_171 )
         {
            ReadRow0515( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               standaloneNotModal0515( ) ;
               GetKey0515( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  Insert0515( ) ;
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( ( nRcdDeleted_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                     {
                        Gx_mode = "DLT";
                        AssignAttri("", false, "Gx_mode", Gx_mode);
                        AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                        Delete0515( ) ;
                     }
                     else
                     {
                        if ( nRcdExists_15 != 0 )
                        {
                           Gx_mode = "UPD";
                           AssignAttri("", false, "Gx_mode", Gx_mode);
                           AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                           Update0515( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, GXCCtl);
                        AnyError = 1;
                        GX_FocusControl = edtLocalidadId_Internalname;
                        AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtSectorId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( edtSectorNombre_Internalname, StringUtil.RTrim( A18SectorNombre)) ;
            ChangePostValue( "ZT_"+"Z17SectorId_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", ""))) ;
            ChangePostValue( "ZT_"+"Z18SectorNombre_"+sGXsfl_171_idx, StringUtil.RTrim( Z18SectorNombre)) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ".", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_171_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ".", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "SECTORID_"+sGXsfl_171_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "SECTORNOMBRE_"+sGXsfl_171_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0515( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_15 = 0;
         nIsMod_15 = 0;
         nRcdDeleted_15 = 0;
      }

      protected void ProcessLevel0514( )
      {
         /* Save parent mode. */
         sMode14 = Gx_mode;
         ProcessNestedLevel0515( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode14;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         /* ' Update level parameters */
      }

      protected void EndLevel0514( )
      {
         if ( ! IsIns( ) )
         {
            pr_default.close(2);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0514( )
      {
         /* Scan By routine */
         /* Using cursor T000541 */
         pr_default.execute(39, new Object[] {A34EspectaculoId});
         RcdFound14 = 0;
         if ( (pr_default.getStatus(39) != 101) )
         {
            RcdFound14 = 1;
            A11LocalidadId = T000541_A11LocalidadId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0514( )
      {
         /* Scan next routine */
         pr_default.readNext(39);
         RcdFound14 = 0;
         if ( (pr_default.getStatus(39) != 101) )
         {
            RcdFound14 = 1;
            A11LocalidadId = T000541_A11LocalidadId[0];
         }
      }

      protected void ScanEnd0514( )
      {
         pr_default.close(39);
      }

      protected void AfterConfirm0514( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0514( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0514( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0514( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0514( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0514( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0514( )
      {
         edtLocalidadId_Enabled = 0;
         AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         edtLocalidadNombre_Enabled = 0;
         AssignProp("", false, edtLocalidadNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadNombre_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         edtLocalidadCapacidad_Enabled = 0;
         AssignProp("", false, edtLocalidadCapacidad_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         edtLocalidadPrecio_Enabled = 0;
         AssignProp("", false, edtLocalidadPrecio_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadPrecio_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         edtLocalidadesVendidas_Enabled = 0;
         AssignProp("", false, edtLocalidadesVendidas_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0), !bGXsfl_128_Refreshing);
         edtLocalidadesDisponibles_Enabled = 0;
         AssignProp("", false, edtLocalidadesDisponibles_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0), !bGXsfl_128_Refreshing);
      }

      protected void ZM0515( short GX_JID )
      {
         if ( ( GX_JID == 33 ) || ( GX_JID == 0 ) )
         {
            if ( ! IsIns( ) )
            {
               Z18SectorNombre = T00053_A18SectorNombre[0];
            }
            else
            {
               Z18SectorNombre = A18SectorNombre;
            }
         }
         if ( GX_JID == -33 )
         {
            Z34EspectaculoId = A34EspectaculoId;
            Z11LocalidadId = A11LocalidadId;
            Z17SectorId = A17SectorId;
            Z18SectorNombre = A18SectorNombre;
         }
      }

      protected void standaloneNotModal0515( )
      {
      }

      protected void standaloneModal0515( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtSectorId_Enabled = 0;
            AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_171_Refreshing);
         }
         else
         {
            edtSectorId_Enabled = 1;
            AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_171_Refreshing);
         }
      }

      protected void Load0515( )
      {
         /* Using cursor T000542 */
         pr_default.execute(40, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(40) != 101) )
         {
            RcdFound15 = 1;
            A18SectorNombre = T000542_A18SectorNombre[0];
            ZM0515( -33) ;
         }
         pr_default.close(40);
         OnLoadActions0515( ) ;
      }

      protected void OnLoadActions0515( )
      {
      }

      protected void CheckExtendedTable0515( )
      {
         nIsDirty_15 = 0;
         Gx_BScreen = 1;
         standaloneModal0515( ) ;
      }

      protected void CloseExtendedTableCursors0515( )
      {
      }

      protected void enableDisable0515( )
      {
      }

      protected void GetKey0515( )
      {
         /* Using cursor T000543 */
         pr_default.execute(41, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(41) != 101) )
         {
            RcdFound15 = 1;
         }
         else
         {
            RcdFound15 = 0;
         }
         pr_default.close(41);
      }

      protected void getByPrimaryKey0515( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0515( 33) ;
            RcdFound15 = 1;
            InitializeNonKey0515( ) ;
            A17SectorId = T00053_A17SectorId[0];
            A18SectorNombre = T00053_A18SectorNombre[0];
            Z34EspectaculoId = A34EspectaculoId;
            Z11LocalidadId = A11LocalidadId;
            Z17SectorId = A17SectorId;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0515( ) ;
            Gx_mode = sMode15;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound15 = 0;
            InitializeNonKey0515( ) ;
            sMode15 = Gx_mode;
            Gx_mode = "DSP";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal0515( ) ;
            Gx_mode = sMode15;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( IsDsp( ) || IsDlt( ) )
         {
            DisableAttributes0515( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0515( )
      {
         if ( ! IsIns( ) )
         {
            /* Using cursor T00052 */
            pr_default.execute(0, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EspectaculoLocalidadSector"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z18SectorNombre, T00052_A18SectorNombre[0]) != 0 ) )
            {
               if ( StringUtil.StrCmp(Z18SectorNombre, T00052_A18SectorNombre[0]) != 0 )
               {
                  GXUtil.WriteLog("espectaculo:[seudo value changed for attri]"+"SectorNombre");
                  GXUtil.WriteLogRaw("Old: ",Z18SectorNombre);
                  GXUtil.WriteLogRaw("Current: ",T00052_A18SectorNombre[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"EspectaculoLocalidadSector"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0515( )
      {
         BeforeValidate0515( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0515( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0515( 0) ;
            CheckOptimisticConcurrency0515( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0515( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0515( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000544 */
                     pr_default.execute(42, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId, A18SectorNombre});
                     pr_default.close(42);
                     dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidadSector") ;
                     if ( (pr_default.getStatus(42) == 1) )
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
               Load0515( ) ;
            }
            EndLevel0515( ) ;
         }
         CloseExtendedTableCursors0515( ) ;
      }

      protected void Update0515( )
      {
         BeforeValidate0515( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0515( ) ;
         }
         if ( ( nIsMod_15 != 0 ) || ( nIsDirty_15 != 0 ) )
         {
            if ( AnyError == 0 )
            {
               CheckOptimisticConcurrency0515( ) ;
               if ( AnyError == 0 )
               {
                  AfterConfirm0515( ) ;
                  if ( AnyError == 0 )
                  {
                     BeforeUpdate0515( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Using cursor T000545 */
                        pr_default.execute(43, new Object[] {A18SectorNombre, A34EspectaculoId, A11LocalidadId, A17SectorId});
                        pr_default.close(43);
                        dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidadSector") ;
                        if ( (pr_default.getStatus(43) == 103) )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"EspectaculoLocalidadSector"}), "RecordIsLocked", 1, "");
                           AnyError = 1;
                        }
                        DeferredUpdate0515( ) ;
                        if ( AnyError == 0 )
                        {
                           /* Start of After( update) rules */
                           /* End of After( update) rules */
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey0515( ) ;
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
               EndLevel0515( ) ;
            }
         }
         CloseExtendedTableCursors0515( ) ;
      }

      protected void DeferredUpdate0515( )
      {
      }

      protected void Delete0515( )
      {
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         BeforeValidate0515( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0515( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0515( ) ;
            AfterConfirm0515( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0515( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000546 */
                  pr_default.execute(44, new Object[] {A34EspectaculoId, A11LocalidadId, A17SectorId});
                  pr_default.close(44);
                  dsDefault.SmartCacheProvider.SetUpdated("EspectaculoLocalidadSector") ;
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
         sMode15 = Gx_mode;
         Gx_mode = "DLT";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0515( ) ;
         Gx_mode = sMode15;
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0515( )
      {
         standaloneModal0515( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel0515( )
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

      public void ScanStart0515( )
      {
         /* Scan By routine */
         /* Using cursor T000547 */
         pr_default.execute(45, new Object[] {A34EspectaculoId, A11LocalidadId});
         RcdFound15 = 0;
         if ( (pr_default.getStatus(45) != 101) )
         {
            RcdFound15 = 1;
            A17SectorId = T000547_A17SectorId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0515( )
      {
         /* Scan next routine */
         pr_default.readNext(45);
         RcdFound15 = 0;
         if ( (pr_default.getStatus(45) != 101) )
         {
            RcdFound15 = 1;
            A17SectorId = T000547_A17SectorId[0];
         }
      }

      protected void ScanEnd0515( )
      {
         pr_default.close(45);
      }

      protected void AfterConfirm0515( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0515( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0515( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0515( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0515( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0515( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0515( )
      {
         edtSectorId_Enabled = 0;
         AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_171_Refreshing);
         edtSectorNombre_Enabled = 0;
         AssignProp("", false, edtSectorNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorNombre_Enabled), 5, 0), !bGXsfl_171_Refreshing);
      }

      protected void send_integrity_lvl_hashes0515( )
      {
      }

      protected void send_integrity_lvl_hashes0514( )
      {
      }

      protected void send_integrity_lvl_hashes057( )
      {
      }

      protected void SubsflControlProps_12814( )
      {
         edtLocalidadId_Internalname = "LOCALIDADID_"+sGXsfl_128_idx;
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE_"+sGXsfl_128_idx;
         edtLocalidadCapacidad_Internalname = "LOCALIDADCAPACIDAD_"+sGXsfl_128_idx;
         edtLocalidadPrecio_Internalname = "LOCALIDADPRECIO_"+sGXsfl_128_idx;
         edtLocalidadesVendidas_Internalname = "LOCALIDADESVENDIDAS_"+sGXsfl_128_idx;
         edtLocalidadesDisponibles_Internalname = "LOCALIDADESDISPONIBLES_"+sGXsfl_128_idx;
         lblTitlesector_Internalname = "TITLESECTOR_"+sGXsfl_128_idx;
         subGridespectaculo_localidad_sector_Internalname = "GRIDESPECTACULO_LOCALIDAD_SECTOR_"+sGXsfl_128_idx;
      }

      protected void SubsflControlProps_fel_12814( )
      {
         edtLocalidadId_Internalname = "LOCALIDADID_"+sGXsfl_128_fel_idx;
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE_"+sGXsfl_128_fel_idx;
         edtLocalidadCapacidad_Internalname = "LOCALIDADCAPACIDAD_"+sGXsfl_128_fel_idx;
         edtLocalidadPrecio_Internalname = "LOCALIDADPRECIO_"+sGXsfl_128_fel_idx;
         edtLocalidadesVendidas_Internalname = "LOCALIDADESVENDIDAS_"+sGXsfl_128_fel_idx;
         edtLocalidadesDisponibles_Internalname = "LOCALIDADESDISPONIBLES_"+sGXsfl_128_fel_idx;
         lblTitlesector_Internalname = "TITLESECTOR_"+sGXsfl_128_fel_idx;
         subGridespectaculo_localidad_sector_Internalname = "GRIDESPECTACULO_LOCALIDAD_SECTOR_"+sGXsfl_128_fel_idx;
      }

      protected void AddRow0514( )
      {
         nRC_GXsfl_171 = 0;
         nGXsfl_128_idx = (int)(nGXsfl_128_idx+1);
         sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx), 4, 0), 4, "0");
         SubsflControlProps_12814( ) ;
         SendRow0514( ) ;
      }

      protected void SendRow0514( )
      {
         Grid1Row = GXWebRow.GetNew(context);
         if ( subGrid1_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGrid1_Backstyle = 0;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
         }
         else if ( subGrid1_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGrid1_Backstyle = 0;
            subGrid1_Backcolor = subGrid1_Allbackcolor;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Uniform";
            }
         }
         else if ( subGrid1_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
            {
               subGrid1_Linesclass = subGrid1_Class+"Odd";
            }
            subGrid1_Backcolor = (int)(0xFFFFFF);
         }
         else if ( subGrid1_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGrid1_Backstyle = 1;
            if ( ((int)((nGXsfl_128_idx) % (2))) == 0 )
            {
               subGrid1_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Even";
               }
            }
            else
            {
               subGrid1_Backcolor = (int)(0xFFFFFF);
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd";
               }
            }
         }
         /* Start of Columns property logic. */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<tr"+" class=\""+subGrid1_Linesclass+"\" style=\""+""+"\""+" data-gxrow=\""+sGXsfl_128_idx+"\">") ;
         }
         if ( GRID1_IsPaging == 0 )
         {
            GXCCtl = "GRIDESPECTACULO_LOCALIDAD_SECTOR_nFirstRecordOnPage_" + sGXsfl_128_idx;
            GRIDESPECTACULO_LOCALIDAD_SECTOR_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         }
         else
         {
            GRIDESPECTACULO_LOCALIDAD_SECTOR_nFirstRecordOnPage = 0;
         }
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divGridtable1_Internalname+"_"+sGXsfl_128_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"Table",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divTable2_Internalname+"_"+sGXsfl_128_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"LevelTable",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCellAdvanced",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"form-group gx-form-group",(String)"left",(String)"top",(String)""+" data-gx-for=\""+edtLocalidadId_Internalname+"\"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadId_Internalname,(String)"Id",(String)"col-sm-3 AttributeLabel",(short)1,(bool)true});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-sm-9 gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 137,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,137);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtLocalidadId_Enabled,(short)1,(String)"number",(String)"1",(short)4,(String)"chr",(short)1,(String)"row",(short)4,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"form-group gx-form-group",(String)"left",(String)"top",(String)""+" data-gx-for=\""+edtLocalidadNombre_Internalname+"\"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadNombre_Internalname,(String)"Nombre",(String)"col-sm-3 AttributeLabel",(short)1,(bool)true});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-sm-9 gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 142,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadNombre_Internalname,StringUtil.RTrim( A12LocalidadNombre),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,142);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtLocalidadNombre_Enabled,(short)0,(String)"text",(String)"",(short)80,(String)"chr",(short)1,(String)"row",(short)100,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"form-group gx-form-group",(String)"left",(String)"top",(String)""+" data-gx-for=\""+edtLocalidadCapacidad_Internalname+"\"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadCapacidad_Internalname,(String)"Capacidad",(String)"col-sm-3 AttributeLabel",(short)1,(bool)true});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-sm-9 gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 147,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadCapacidad_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A13LocalidadCapacidad), 5, 0, ".", "")),((edtLocalidadCapacidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")) : context.localUtil.Format( (decimal)(A13LocalidadCapacidad), "ZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,147);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadCapacidad_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtLocalidadCapacidad_Enabled,(short)0,(String)"number",(String)"1",(short)5,(String)"chr",(short)1,(String)"row",(short)5,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"form-group gx-form-group",(String)"left",(String)"top",(String)""+" data-gx-for=\""+edtLocalidadPrecio_Internalname+"\"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadPrecio_Internalname,(String)"Precio",(String)"col-sm-3 AttributeLabel",(short)1,(bool)true});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-sm-9 gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 152,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( A14LocalidadPrecio, 9, 2, ".", "")),((edtLocalidadPrecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")) : context.localUtil.Format( A14LocalidadPrecio, "ZZZZZ9.99")),TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,152);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadPrecio_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtLocalidadPrecio_Enabled,(short)0,(String)"text",(String)"",(short)9,(String)"chr",(short)1,(String)"row",(short)9,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"form-group gx-form-group",(String)"left",(String)"top",(String)""+" data-gx-for=\""+edtLocalidadesVendidas_Internalname+"\"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadesVendidas_Internalname,(String)"Vendidas",(String)"col-sm-3 AttributeLabel",(short)1,(bool)true});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-sm-9 gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 157,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadesVendidas_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A15LocalidadesVendidas), 5, 0, ".", "")),((edtLocalidadesVendidas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A15LocalidadesVendidas), "ZZZZ9")) : context.localUtil.Format( (decimal)(A15LocalidadesVendidas), "ZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,157);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadesVendidas_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtLocalidadesVendidas_Enabled,(short)0,(String)"number",(String)"1",(short)5,(String)"chr",(short)1,(String)"row",(short)5,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"form-group gx-form-group",(String)"left",(String)"top",(String)""+" data-gx-for=\""+edtLocalidadesDisponibles_Internalname+"\"",(String)"",(String)"div"});
         /* Attribute/Variable Label */
         Grid1Row.AddColumnProperties("html_label", -1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadesDisponibles_Internalname,(String)"Disponibles",(String)"col-sm-3 AttributeLabel",(short)1,(bool)true});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-sm-9 gx-attribute",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 162,'',false,'" + sGXsfl_128_idx + "',128)\"";
         ROClassString = "Attribute";
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadesDisponibles_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A16LocalidadesDisponibles), 5, 0, ".", "")),((edtLocalidadesDisponibles_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")) : context.localUtil.Format( (decimal)(A16LocalidadesDisponibles), "ZZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,162);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadesDisponibles_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)1,(int)edtLocalidadesDisponibles_Enabled,(short)0,(String)"number",(String)"1",(short)5,(String)"chr",(short)1,(String)"row",(short)5,(short)0,(short)0,(short)128,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false,(String)""});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 col-sm-9 col-sm-offset-3 LevelTable",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)divSectortable_Internalname+"_"+sGXsfl_128_idx,(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"LevelTable",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12 FormCell",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Text block */
         Grid1Row.AddColumnProperties("label", 1, isAjaxCallMode( ), new Object[] {(String)lblTitlesector_Internalname,(String)"Sector",(String)"",(String)"",(String)lblTitlesector_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"Title",(short)0,(String)"",(short)1,(short)1,(short)0});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"row",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /* Div Control */
         Grid1Row.AddColumnProperties("div_start", -1, isAjaxCallMode( ), new Object[] {(String)"",(short)1,(short)0,(String)"px",(short)0,(String)"px",(String)"col-xs-12",(String)"left",(String)"top",(String)"",(String)"",(String)"div"});
         /*  Child Grid Control  */
         Grid1Row.AddColumnProperties("subfile", -1, isAjaxCallMode( ), new Object[] {(String)"Gridespectaculo_localidad_sectorContainer"});
         if ( isAjaxCallMode( ) )
         {
            Gridespectaculo_localidad_sectorContainer = new GXWebGrid( context);
         }
         else
         {
            Gridespectaculo_localidad_sectorContainer.Clear();
         }
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("GridName", "Gridespectaculo_localidad_sector");
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Header", subGridespectaculo_localidad_sector_Header);
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Class", "Grid");
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Backcolorstyle), 1, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("CmpContext", "");
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("InMasterPage", "false");
         Gridespectaculo_localidad_sectorColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridespectaculo_localidad_sectorColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")));
         Gridespectaculo_localidad_sectorColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddColumnProperties(Gridespectaculo_localidad_sectorColumn);
         Gridespectaculo_localidad_sectorColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
         Gridespectaculo_localidad_sectorColumn.AddObjectProperty("Value", StringUtil.RTrim( A18SectorNombre));
         Gridespectaculo_localidad_sectorColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddColumnProperties(Gridespectaculo_localidad_sectorColumn);
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Selectedindex), 4, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Allowselection), 1, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Selectioncolor), 9, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Allowhovering), 1, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Hoveringcolor), 9, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Allowcollapsing), 1, 0, ".", "")));
         Gridespectaculo_localidad_sectorContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridespectaculo_localidad_sector_Collapsed), 1, 0, ".", "")));
         nGXsfl_171_idx = 0;
         if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
         {
            /* Enter key processing. */
            nBlankRcdCount15 = 5;
            if ( ! IsIns( ) )
            {
               /* Display confirmed (stored) records */
               nRcdExists_15 = 1;
               ScanStart0515( ) ;
               while ( RcdFound15 != 0 )
               {
                  init_level_properties15( ) ;
                  getByPrimaryKey0515( ) ;
                  AddRow0515( ) ;
                  ScanNext0515( ) ;
               }
               ScanEnd0515( ) ;
               nBlankRcdCount15 = 5;
            }
         }
         else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
         {
            /* Button check  or addlines. */
            standaloneNotModal0515( ) ;
            standaloneModal0515( ) ;
            sMode15 = Gx_mode;
            while ( nGXsfl_171_idx < nRC_GXsfl_171 )
            {
               bGXsfl_171_Refreshing = true;
               ReadRow0515( ) ;
               edtSectorId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORID_"+sGXsfl_171_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_171_Refreshing);
               edtSectorNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORNOMBRE_"+sGXsfl_171_idx+"Enabled"), ".", ","));
               AssignProp("", false, edtSectorNombre_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorNombre_Enabled), 5, 0), !bGXsfl_171_Refreshing);
               if ( ( nRcdExists_15 == 0 ) && ! IsIns( ) )
               {
                  Gx_mode = "INS";
                  AssignAttri("", false, "Gx_mode", Gx_mode);
                  AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  standaloneModal0515( ) ;
               }
               SendRow0515( ) ;
               bGXsfl_171_Refreshing = false;
            }
            Gx_mode = sMode15;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            /* Get or get-alike key processing. */
            nBlankRcdCount15 = 5;
            nRcdExists_15 = 1;
            if ( ! IsIns( ) )
            {
               ScanStart0515( ) ;
               while ( RcdFound15 != 0 )
               {
                  sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx+1), 4, 0), 4, "0") + sGXsfl_128_idx;
                  SubsflControlProps_17115( ) ;
                  init_level_properties15( ) ;
                  standaloneNotModal0515( ) ;
                  getByPrimaryKey0515( ) ;
                  standaloneModal0515( ) ;
                  AddRow0515( ) ;
                  ScanNext0515( ) ;
               }
               ScanEnd0515( ) ;
            }
         }
         /* Initialize fields for 'new' records and send them. */
         if ( ! IsDsp( ) && ! IsDlt( ) )
         {
            sMode15 = Gx_mode;
            Gx_mode = "INS";
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx+1), 4, 0), 4, "0") + sGXsfl_128_idx;
            SubsflControlProps_17115( ) ;
            InitAll0515( ) ;
            init_level_properties15( ) ;
            nRcdExists_15 = 0;
            nIsMod_15 = 0;
            nRcdDeleted_15 = 0;
            if ( ( NumberUtil.Val( EvtGridId, ".") + NumberUtil.Val( EvtRowId, ".") == Convert.ToDecimal( 0 )) || (Convert.ToDecimal( 128 ) == NumberUtil.Val( EvtGridId, ".") ) && ( NumberUtil.Val( EvtRowId, ".") == NumberUtil.Val( sGXsfl_128_idx, ".") ) )
            {
               nBlankRcdCount15 = (short)(nBlankRcdUsr15+nBlankRcdCount15);
            }
            fRowAdded = 0;
            while ( nBlankRcdCount15 > 0 )
            {
               standaloneNotModal0515( ) ;
               standaloneModal0515( ) ;
               AddRow0515( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1;
                  GX_FocusControl = edtSectorId_Internalname;
                  AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount15 = (short)(nBlankRcdCount15-1);
            }
            Gx_mode = sMode15;
            AssignAttri("", false, "Gx_mode", Gx_mode);
            AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         if ( ! isAjaxCallMode( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridespectaculo_localidad_sectorContainerData"+"_"+sGXsfl_128_idx, Gridespectaculo_localidad_sectorContainer.ToJavascriptSource());
         }
         if ( isAjaxCallMode( ) )
         {
            Grid1Row.AddGrid("Gridespectaculo_localidad_sector", Gridespectaculo_localidad_sectorContainer);
         }
         if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
         {
            GxWebStd.gx_hidden_field( context, "Gridespectaculo_localidad_sectorContainerData"+"V_"+sGXsfl_128_idx, Gridespectaculo_localidad_sectorContainer.GridValuesHidden());
         }
         else
         {
            context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridespectaculo_localidad_sectorContainerData"+"V_"+sGXsfl_128_idx+"\" value='"+Gridespectaculo_localidad_sectorContainer.GridValuesHidden()+"'/>") ;
         }
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         Grid1Row.AddColumnProperties("div_end", -1, isAjaxCallMode( ), new Object[] {(String)"left",(String)"top",(String)"div"});
         context.httpAjaxContext.ajax_sending_grid_row(Grid1Row);
         send_integrity_lvl_hashes0514( ) ;
         GXCCtl = "Z11LocalidadId_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11LocalidadId), 4, 0, ".", "")));
         GXCCtl = "Z12LocalidadNombre_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z12LocalidadNombre));
         GXCCtl = "Z13LocalidadCapacidad_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z13LocalidadCapacidad), 5, 0, ".", "")));
         GXCCtl = "Z14LocalidadPrecio_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( Z14LocalidadPrecio, 9, 2, ".", "")));
         GXCCtl = "Z15LocalidadesVendidas_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z15LocalidadesVendidas), 5, 0, ".", "")));
         GXCCtl = "Z16LocalidadesDisponibles_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z16LocalidadesDisponibles), 5, 0, ".", "")));
         GXCCtl = "nRC_GXsfl_171_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_171_idx), 8, 0, ".", "")));
         GXCCtl = "nRcdDeleted_14_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_14), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_14_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_14), 4, 0, ".", "")));
         GXCCtl = "nIsMod_14_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_14), 4, 0, ".", "")));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_128_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vESPECTACULOID_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19EspectaculoId), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_128_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "LOCALIDADID_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADNOMBRE_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADCAPACIDAD_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadCapacidad_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADPRECIO_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadPrecio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADESVENDIDAS_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesVendidas_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LOCALIDADESDISPONIBLES_"+sGXsfl_128_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLocalidadesDisponibles_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         GRIDESPECTACULO_LOCALIDAD_SECTOR_nFirstRecordOnPage = 0;
         GRIDESPECTACULO_LOCALIDAD_SECTOR_nCurrentRecord = 0;
         /* End of Columns property logic. */
         Grid1Container.AddRow(Grid1Row);
      }

      protected void ReadRow0514( )
      {
         nGXsfl_128_idx = (int)(nGXsfl_128_idx+1);
         sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx), 4, 0), 4, "0");
         SubsflControlProps_12814( ) ;
         edtLocalidadId_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADID_"+sGXsfl_128_idx+"Enabled"), ".", ","));
         edtLocalidadNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADNOMBRE_"+sGXsfl_128_idx+"Enabled"), ".", ","));
         edtLocalidadCapacidad_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADCAPACIDAD_"+sGXsfl_128_idx+"Enabled"), ".", ","));
         edtLocalidadPrecio_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADPRECIO_"+sGXsfl_128_idx+"Enabled"), ".", ","));
         edtLocalidadesVendidas_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADESVENDIDAS_"+sGXsfl_128_idx+"Enabled"), ".", ","));
         edtLocalidadesDisponibles_Enabled = (int)(context.localUtil.CToN( cgiGet( "LOCALIDADESDISPONIBLES_"+sGXsfl_128_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "LOCALIDADID_" + sGXsfl_128_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtLocalidadId_Internalname;
            wbErr = true;
            A11LocalidadId = 0;
         }
         else
         {
            A11LocalidadId = (short)(context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ","));
         }
         A12LocalidadNombre = cgiGet( edtLocalidadNombre_Internalname);
         if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
         {
            GXCCtl = "LOCALIDADCAPACIDAD_" + sGXsfl_128_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtLocalidadCapacidad_Internalname;
            wbErr = true;
            A13LocalidadCapacidad = 0;
         }
         else
         {
            A13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( edtLocalidadCapacidad_Internalname), ".", ","));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",") > 999999.99m ) ) )
         {
            GXCCtl = "LOCALIDADPRECIO_" + sGXsfl_128_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtLocalidadPrecio_Internalname;
            wbErr = true;
            A14LocalidadPrecio = 0;
         }
         else
         {
            A14LocalidadPrecio = context.localUtil.CToN( cgiGet( edtLocalidadPrecio_Internalname), ".", ",");
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
         {
            GXCCtl = "LOCALIDADESVENDIDAS_" + sGXsfl_128_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtLocalidadesVendidas_Internalname;
            wbErr = true;
            A15LocalidadesVendidas = 0;
         }
         else
         {
            A15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( edtLocalidadesVendidas_Internalname), ".", ","));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
         {
            GXCCtl = "LOCALIDADESDISPONIBLES_" + sGXsfl_128_idx;
            GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, GXCCtl);
            AnyError = 1;
            GX_FocusControl = edtLocalidadesDisponibles_Internalname;
            wbErr = true;
            A16LocalidadesDisponibles = 0;
         }
         else
         {
            A16LocalidadesDisponibles = (int)(context.localUtil.CToN( cgiGet( edtLocalidadesDisponibles_Internalname), ".", ","));
         }
         GXCCtl = "Z11LocalidadId_" + sGXsfl_128_idx;
         Z11LocalidadId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z12LocalidadNombre_" + sGXsfl_128_idx;
         Z12LocalidadNombre = cgiGet( GXCCtl);
         GXCCtl = "Z13LocalidadCapacidad_" + sGXsfl_128_idx;
         Z13LocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z14LocalidadPrecio_" + sGXsfl_128_idx;
         Z14LocalidadPrecio = context.localUtil.CToN( cgiGet( GXCCtl), ".", ",");
         GXCCtl = "Z15LocalidadesVendidas_" + sGXsfl_128_idx;
         Z15LocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z16LocalidadesDisponibles_" + sGXsfl_128_idx;
         Z16LocalidadesDisponibles = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRC_GXsfl_171_" + sGXsfl_128_idx;
         nRC_GXsfl_171 = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdDeleted_14_" + sGXsfl_128_idx;
         nRcdDeleted_14 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_14_" + sGXsfl_128_idx;
         nRcdExists_14 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_14_" + sGXsfl_128_idx;
         nIsMod_14 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRC_GXsfl_171_" + sGXsfl_128_idx;
         nRC_GXsfl_171 = (int)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void SubsflControlProps_17115( )
      {
         edtSectorId_Internalname = "SECTORID_"+sGXsfl_171_idx;
         edtSectorNombre_Internalname = "SECTORNOMBRE_"+sGXsfl_171_idx;
      }

      protected void SubsflControlProps_fel_17115( )
      {
         edtSectorId_Internalname = "SECTORID_"+sGXsfl_171_fel_idx;
         edtSectorNombre_Internalname = "SECTORNOMBRE_"+sGXsfl_171_fel_idx;
      }

      protected void AddRow0515( )
      {
         nGXsfl_171_idx = (int)(nGXsfl_171_idx+1);
         sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx), 4, 0), 4, "0") + sGXsfl_128_idx;
         SubsflControlProps_17115( ) ;
         SendRow0515( ) ;
      }

      protected void SendRow0515( )
      {
         Gridespectaculo_localidad_sectorRow = GXWebRow.GetNew(context);
         if ( subGridespectaculo_localidad_sector_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridespectaculo_localidad_sector_Backstyle = 0;
            if ( StringUtil.StrCmp(subGridespectaculo_localidad_sector_Class, "") != 0 )
            {
               subGridespectaculo_localidad_sector_Linesclass = subGridespectaculo_localidad_sector_Class+"Odd";
            }
         }
         else if ( subGridespectaculo_localidad_sector_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridespectaculo_localidad_sector_Backstyle = 0;
            subGridespectaculo_localidad_sector_Backcolor = subGridespectaculo_localidad_sector_Allbackcolor;
            if ( StringUtil.StrCmp(subGridespectaculo_localidad_sector_Class, "") != 0 )
            {
               subGridespectaculo_localidad_sector_Linesclass = subGridespectaculo_localidad_sector_Class+"Uniform";
            }
         }
         else if ( subGridespectaculo_localidad_sector_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridespectaculo_localidad_sector_Backstyle = 1;
            if ( StringUtil.StrCmp(subGridespectaculo_localidad_sector_Class, "") != 0 )
            {
               subGridespectaculo_localidad_sector_Linesclass = subGridespectaculo_localidad_sector_Class+"Odd";
            }
            subGridespectaculo_localidad_sector_Backcolor = (int)(0x0);
         }
         else if ( subGridespectaculo_localidad_sector_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridespectaculo_localidad_sector_Backstyle = 1;
            if ( ((int)((nGXsfl_171_idx) % (2))) == 0 )
            {
               subGridespectaculo_localidad_sector_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridespectaculo_localidad_sector_Class, "") != 0 )
               {
                  subGridespectaculo_localidad_sector_Linesclass = subGridespectaculo_localidad_sector_Class+"Even";
               }
            }
            else
            {
               subGridespectaculo_localidad_sector_Backcolor = (int)(0x0);
               if ( StringUtil.StrCmp(subGridespectaculo_localidad_sector_Class, "") != 0 )
               {
                  subGridespectaculo_localidad_sector_Linesclass = subGridespectaculo_localidad_sector_Class+"Odd";
               }
            }
         }
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_171_idx + "',1);gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 172,'',false,'" + sGXsfl_171_idx + "',171)\"";
         ROClassString = "Attribute";
         Gridespectaculo_localidad_sectorRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSectorId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A17SectorId), 4, 0, ".", "")),StringUtil.LTrim( context.localUtil.Format( (decimal)(A17SectorId), "ZZZ9")),TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,172);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSectorId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSectorId_Enabled,(short)1,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)171,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " data-gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_171_idx + "',1);gx.fn.setControlValue('nIsMod_14_" + sGXsfl_128_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 173,'',false,'" + sGXsfl_171_idx + "',171)\"";
         ROClassString = "Attribute";
         Gridespectaculo_localidad_sectorRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSectorNombre_Internalname,StringUtil.RTrim( A18SectorNombre),(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,173);\"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtSectorNombre_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)-1,(int)edtSectorNombre_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)171,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
         context.httpAjaxContext.ajax_sending_grid_row(Gridespectaculo_localidad_sectorRow);
         send_integrity_lvl_hashes0515( ) ;
         GXCCtl = "Z17SectorId_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z17SectorId), 4, 0, ".", "")));
         GXCCtl = "Z18SectorNombre_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z18SectorNombre));
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ".", "")));
         GXCCtl = "nRcdExists_15_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ".", "")));
         GXCCtl = "nIsMod_15_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ".", "")));
         GXCCtl = "vMODE_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Gx_mode));
         GXCCtl = "vTRNCONTEXT_" + sGXsfl_171_idx;
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, GXCCtl, AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(GXCCtl, AV9TrnContext);
         }
         GXCCtl = "vESPECTACULOID_" + sGXsfl_171_idx;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SECTORID_"+sGXsfl_171_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "SECTORNOMBRE_"+sGXsfl_171_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtSectorNombre_Enabled), 5, 0, ".", "")));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridespectaculo_localidad_sectorContainer.AddRow(Gridespectaculo_localidad_sectorRow);
      }

      protected void ReadRow0515( )
      {
         nGXsfl_171_idx = (int)(nGXsfl_171_idx+1);
         sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx), 4, 0), 4, "0") + sGXsfl_128_idx;
         SubsflControlProps_17115( ) ;
         edtSectorId_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORID_"+sGXsfl_171_idx+"Enabled"), ".", ","));
         edtSectorNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "SECTORNOMBRE_"+sGXsfl_171_idx+"Enabled"), ".", ","));
         if ( ( ( context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSectorId_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
         {
            GXCCtl = "SECTORID_" + sGXsfl_171_idx;
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
         GXCCtl = "Z17SectorId_" + sGXsfl_171_idx;
         Z17SectorId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "Z18SectorNombre_" + sGXsfl_171_idx;
         Z18SectorNombre = cgiGet( GXCCtl);
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_171_idx;
         nRcdDeleted_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nRcdExists_15_" + sGXsfl_171_idx;
         nRcdExists_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
         GXCCtl = "nIsMod_15_" + sGXsfl_171_idx;
         nIsMod_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ".", ","));
      }

      protected void assign_properties_default( )
      {
         defedtSectorId_Enabled = edtSectorId_Enabled;
         defedtLocalidadId_Enabled = edtLocalidadId_Enabled;
      }

      protected void ConfirmValues050( )
      {
         nGXsfl_171_idx = 0;
         sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx), 4, 0), 4, "0") + sGXsfl_128_idx;
         SubsflControlProps_17115( ) ;
         while ( nGXsfl_171_idx < nRC_GXsfl_171 )
         {
            nGXsfl_171_idx = (int)(nGXsfl_171_idx+1);
            sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx), 4, 0), 4, "0") + sGXsfl_128_idx;
            SubsflControlProps_17115( ) ;
            ChangePostValue( "Z17SectorId_"+sGXsfl_171_idx, cgiGet( "ZT_"+"Z17SectorId_"+sGXsfl_171_idx)) ;
            DeletePostValue( "ZT_"+"Z17SectorId_"+sGXsfl_171_idx) ;
            ChangePostValue( "Z18SectorNombre_"+sGXsfl_171_idx, cgiGet( "ZT_"+"Z18SectorNombre_"+sGXsfl_171_idx)) ;
            DeletePostValue( "ZT_"+"Z18SectorNombre_"+sGXsfl_171_idx) ;
         }
         nGXsfl_128_idx = 0;
         sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx), 4, 0), 4, "0");
         SubsflControlProps_12814( ) ;
         while ( nGXsfl_128_idx < nRC_GXsfl_128 )
         {
            nGXsfl_128_idx = (int)(nGXsfl_128_idx+1);
            sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx), 4, 0), 4, "0");
            SubsflControlProps_12814( ) ;
            ChangePostValue( "Z11LocalidadId_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z11LocalidadId_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z11LocalidadId_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z12LocalidadNombre_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z12LocalidadNombre_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z12LocalidadNombre_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z13LocalidadCapacidad_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z13LocalidadCapacidad_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z13LocalidadCapacidad_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z14LocalidadPrecio_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z14LocalidadPrecio_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z14LocalidadPrecio_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z15LocalidadesVendidas_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z15LocalidadesVendidas_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z15LocalidadesVendidas_"+sGXsfl_128_idx) ;
            ChangePostValue( "Z16LocalidadesDisponibles_"+sGXsfl_128_idx, cgiGet( "ZT_"+"Z16LocalidadesDisponibles_"+sGXsfl_128_idx)) ;
            DeletePostValue( "ZT_"+"Z16LocalidadesDisponibles_"+sGXsfl_128_idx) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202021701365", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("calendar-en.js", "?"+context.GetBuildNumber( 138086), false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("espectaculo.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV19EspectaculoId)+"\">") ;
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
         forbiddenHiddens.Add("hshsalt", "hsh"+"Espectaculo");
         forbiddenHiddens.Add("Gx_mode", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("espectaculo:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z34EspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z35EspectaculoNombre", StringUtil.RTrim( Z35EspectaculoNombre));
         GxWebStd.gx_hidden_field( context, "Z36EspectaculoFecha", context.localUtil.DToC( Z36EspectaculoFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z8LugarId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z8LugarId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z6TipoEspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z6TipoEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z19EspectaculoPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19EspectaculoPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z29LugarPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29LugarPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z22EspectaculoCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22EspectaculoCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z32LugarCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32LugarCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_128", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_128_idx), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N6TipoEspectaculoId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A6TipoEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N19EspectaculoPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19EspectaculoPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N22EspectaculoCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22EspectaculoCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N8LugarId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N29LugarPaisId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29LugarPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "N32LugarCiudadId", StringUtil.LTrim( StringUtil.NToC( (decimal)(A32LugarCiudadId), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV9TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV9TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "gxhash_vTRNCONTEXT", GetSecureSignedToken( "", AV9TrnContext, context));
         GxWebStd.gx_hidden_field( context, "vESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV19EspectaculoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_TIPOESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11Insert_TipoEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_ESPECTACULOPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12Insert_EspectaculoPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_ESPECTACULOCIUDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_EspectaculoCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_LUGARID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14Insert_LugarId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_LUGARPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15Insert_LugarPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINSERT_LUGARCIUDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16Insert_LugarCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LUGARFOTO_GXI", A40001LugarFoto_GXI);
         GxWebStd.gx_hidden_field( context, "ESPECTACULOPAISBANDERA_GXI", A40000EspectaculoPaisBandera_GXI);
         GxWebStd.gx_hidden_field( context, "LUGARPAISBANDERA_GXI", A40002LugarPaisBandera_GXI);
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV20Pgmname));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GXCCtlgxBlob = "ESPECTACULOPAISBANDERA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A21EspectaculoPaisBandera);
         GXCCtlgxBlob = "LUGARFOTO" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A10LugarFoto);
         GXCCtlgxBlob = "LUGARPAISBANDERA" + "_gxBlob";
         GxWebStd.gx_hidden_field( context, GXCCtlgxBlob, A31LugarPaisBandera);
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
         return formatLink("espectaculo.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV19EspectaculoId) ;
      }

      public override String GetPgmname( )
      {
         return "Espectaculo" ;
      }

      public override String GetPgmdesc( )
      {
         return "Espectaculo" ;
      }

      protected void InitializeNonKey057( )
      {
         A6TipoEspectaculoId = 0;
         AssignAttri("", false, "A6TipoEspectaculoId", StringUtil.LTrimStr( (decimal)(A6TipoEspectaculoId), 4, 0));
         A19EspectaculoPaisId = 0;
         AssignAttri("", false, "A19EspectaculoPaisId", StringUtil.LTrimStr( (decimal)(A19EspectaculoPaisId), 4, 0));
         A22EspectaculoCiudadId = 0;
         AssignAttri("", false, "A22EspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(A22EspectaculoCiudadId), 4, 0));
         A8LugarId = 0;
         AssignAttri("", false, "A8LugarId", StringUtil.LTrimStr( (decimal)(A8LugarId), 4, 0));
         A29LugarPaisId = 0;
         AssignAttri("", false, "A29LugarPaisId", StringUtil.LTrimStr( (decimal)(A29LugarPaisId), 4, 0));
         A32LugarCiudadId = 0;
         AssignAttri("", false, "A32LugarCiudadId", StringUtil.LTrimStr( (decimal)(A32LugarCiudadId), 4, 0));
         A35EspectaculoNombre = "";
         AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
         A36EspectaculoFecha = DateTime.MinValue;
         AssignAttri("", false, "A36EspectaculoFecha", context.localUtil.Format(A36EspectaculoFecha, "99/99/99"));
         A7TipoEspectaculoNombre = "";
         AssignAttri("", false, "A7TipoEspectaculoNombre", A7TipoEspectaculoNombre);
         A20EspectaculoPaisNombre = "";
         AssignAttri("", false, "A20EspectaculoPaisNombre", A20EspectaculoPaisNombre);
         A21EspectaculoPaisBandera = "";
         AssignAttri("", false, "A21EspectaculoPaisBandera", A21EspectaculoPaisBandera);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         A40000EspectaculoPaisBandera_GXI = "";
         n40000EspectaculoPaisBandera_GXI = false;
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A21EspectaculoPaisBandera)) ? A40000EspectaculoPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A21EspectaculoPaisBandera))), true);
         AssignProp("", false, imgEspectaculoPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A21EspectaculoPaisBandera), true);
         A23EspectaculoCiudadNombre = "";
         AssignAttri("", false, "A23EspectaculoCiudadNombre", A23EspectaculoCiudadNombre);
         A9LugarNombre = "";
         AssignAttri("", false, "A9LugarNombre", A9LugarNombre);
         A10LugarFoto = "";
         AssignAttri("", false, "A10LugarFoto", A10LugarFoto);
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         A40001LugarFoto_GXI = "";
         AssignProp("", false, imgLugarFoto_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A10LugarFoto)) ? A40001LugarFoto_GXI : context.convertURL( context.PathToRelativeUrl( A10LugarFoto))), true);
         AssignProp("", false, imgLugarFoto_Internalname, "SrcSet", context.GetImageSrcSet( A10LugarFoto), true);
         A30LugarPaisNombre = "";
         AssignAttri("", false, "A30LugarPaisNombre", A30LugarPaisNombre);
         A31LugarPaisBandera = "";
         AssignAttri("", false, "A31LugarPaisBandera", A31LugarPaisBandera);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
         A40002LugarPaisBandera_GXI = "";
         n40002LugarPaisBandera_GXI = false;
         AssignProp("", false, imgLugarPaisBandera_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( A31LugarPaisBandera)) ? A40002LugarPaisBandera_GXI : context.convertURL( context.PathToRelativeUrl( A31LugarPaisBandera))), true);
         AssignProp("", false, imgLugarPaisBandera_Internalname, "SrcSet", context.GetImageSrcSet( A31LugarPaisBandera), true);
         A33LugarCiudadNombre = "";
         AssignAttri("", false, "A33LugarCiudadNombre", A33LugarCiudadNombre);
         Z35EspectaculoNombre = "";
         Z36EspectaculoFecha = DateTime.MinValue;
         Z8LugarId = 0;
         Z6TipoEspectaculoId = 0;
         Z19EspectaculoPaisId = 0;
         Z29LugarPaisId = 0;
         Z22EspectaculoCiudadId = 0;
         Z32LugarCiudadId = 0;
      }

      protected void InitAll057( )
      {
         A34EspectaculoId = 0;
         AssignAttri("", false, "A34EspectaculoId", StringUtil.LTrimStr( (decimal)(A34EspectaculoId), 4, 0));
         InitializeNonKey057( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0514( )
      {
         A12LocalidadNombre = "";
         A13LocalidadCapacidad = 0;
         A14LocalidadPrecio = 0;
         A15LocalidadesVendidas = 0;
         A16LocalidadesDisponibles = 0;
         Z12LocalidadNombre = "";
         Z13LocalidadCapacidad = 0;
         Z14LocalidadPrecio = 0;
         Z15LocalidadesVendidas = 0;
         Z16LocalidadesDisponibles = 0;
      }

      protected void InitAll0514( )
      {
         A11LocalidadId = 0;
         InitializeNonKey0514( ) ;
      }

      protected void StandaloneModalInsert0514( )
      {
      }

      protected void InitializeNonKey0515( )
      {
         A18SectorNombre = "";
         Z18SectorNombre = "";
      }

      protected void InitAll0515( )
      {
         A17SectorId = 0;
         InitializeNonKey0515( ) ;
      }

      protected void StandaloneModalInsert0515( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "");
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020217013619", true, true);
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
         context.AddJavascriptSource("espectaculo.js", "?2020217013619", false, true);
         /* End function include_jscripts */
      }

      protected void init_level_properties14( )
      {
         edtLocalidadId_Enabled = defedtLocalidadId_Enabled;
         AssignProp("", false, edtLocalidadId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtLocalidadId_Enabled), 5, 0), !bGXsfl_128_Refreshing);
      }

      protected void init_level_properties15( )
      {
         edtSectorId_Enabled = defedtSectorId_Enabled;
         AssignProp("", false, edtSectorId_Internalname, "Enabled", StringUtil.LTrimStr( (decimal)(edtSectorId_Enabled), 5, 0), !bGXsfl_171_Refreshing);
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
         edtEspectaculoId_Internalname = "ESPECTACULOID";
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE";
         edtEspectaculoFecha_Internalname = "ESPECTACULOFECHA";
         edtTipoEspectaculoId_Internalname = "TIPOESPECTACULOID";
         edtTipoEspectaculoNombre_Internalname = "TIPOESPECTACULONOMBRE";
         edtEspectaculoPaisId_Internalname = "ESPECTACULOPAISID";
         edtEspectaculoPaisNombre_Internalname = "ESPECTACULOPAISNOMBRE";
         imgEspectaculoPaisBandera_Internalname = "ESPECTACULOPAISBANDERA";
         edtEspectaculoCiudadId_Internalname = "ESPECTACULOCIUDADID";
         edtEspectaculoCiudadNombre_Internalname = "ESPECTACULOCIUDADNOMBRE";
         edtLugarId_Internalname = "LUGARID";
         edtLugarNombre_Internalname = "LUGARNOMBRE";
         imgLugarFoto_Internalname = "LUGARFOTO";
         edtLugarPaisId_Internalname = "LUGARPAISID";
         edtLugarPaisNombre_Internalname = "LUGARPAISNOMBRE";
         imgLugarPaisBandera_Internalname = "LUGARPAISBANDERA";
         edtLugarCiudadId_Internalname = "LUGARCIUDADID";
         edtLugarCiudadNombre_Internalname = "LUGARCIUDADNOMBRE";
         lblTitlelocalidad_Internalname = "TITLELOCALIDAD";
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
         divTable2_Internalname = "TABLE2";
         divGridtable1_Internalname = "GRIDTABLE1";
         divLocalidadtable_Internalname = "LOCALIDADTABLE";
         divFormcontainer_Internalname = "FORMCONTAINER";
         bttBtn_enter_Internalname = "BTN_ENTER";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         bttBtn_delete_Internalname = "BTN_DELETE";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_6_Internalname = "PROMPT_6";
         imgprompt_19_Internalname = "PROMPT_19";
         imgprompt_22_Internalname = "PROMPT_22";
         imgprompt_8_Internalname = "PROMPT_8";
         imgprompt_29_Internalname = "PROMPT_29";
         imgprompt_32_Internalname = "PROMPT_32";
         subGridespectaculo_localidad_sector_Internalname = "GRIDESPECTACULO_LOCALIDAD_SECTOR";
         subGrid1_Internalname = "GRID1";
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
         Form.Caption = "Espectaculo";
         edtSectorNombre_Jsonclick = "";
         edtSectorId_Jsonclick = "";
         subGridespectaculo_localidad_sector_Class = "Grid";
         subGridespectaculo_localidad_sector_Backcolorstyle = 0;
         subGridespectaculo_localidad_sector_Allowcollapsing = 0;
         subGridespectaculo_localidad_sector_Allowselection = 0;
         subGridespectaculo_localidad_sector_Header = "";
         edtLocalidadesDisponibles_Jsonclick = "";
         edtLocalidadesVendidas_Jsonclick = "";
         edtLocalidadPrecio_Jsonclick = "";
         edtLocalidadCapacidad_Jsonclick = "";
         edtLocalidadNombre_Jsonclick = "";
         edtLocalidadId_Jsonclick = "";
         subGrid1_Class = "TrnSublevelGrid";
         edtSectorNombre_Enabled = 1;
         edtSectorId_Enabled = 1;
         subGrid1_Allowcollapsing = 0;
         lblTitlesector_Caption = "Sector";
         edtLocalidadesDisponibles_Enabled = 1;
         edtLocalidadesVendidas_Enabled = 1;
         edtLocalidadPrecio_Enabled = 1;
         edtLocalidadCapacidad_Enabled = 1;
         edtLocalidadNombre_Enabled = 1;
         edtLocalidadId_Enabled = 1;
         subGrid1_Backcolorstyle = 0;
         bttBtn_delete_Enabled = 0;
         bttBtn_delete_Visible = 1;
         bttBtn_cancel_Visible = 1;
         bttBtn_enter_Enabled = 1;
         bttBtn_enter_Visible = 1;
         edtLugarCiudadNombre_Jsonclick = "";
         edtLugarCiudadNombre_Enabled = 0;
         imgprompt_32_Visible = 1;
         imgprompt_32_Link = "";
         edtLugarCiudadId_Jsonclick = "";
         edtLugarCiudadId_Enabled = 1;
         imgLugarPaisBandera_Enabled = 0;
         edtLugarPaisNombre_Jsonclick = "";
         edtLugarPaisNombre_Enabled = 0;
         imgprompt_29_Visible = 1;
         imgprompt_29_Link = "";
         edtLugarPaisId_Jsonclick = "";
         edtLugarPaisId_Enabled = 1;
         imgLugarFoto_Enabled = 0;
         edtLugarNombre_Jsonclick = "";
         edtLugarNombre_Enabled = 0;
         imgprompt_8_Visible = 1;
         imgprompt_8_Link = "";
         edtLugarId_Jsonclick = "";
         edtLugarId_Enabled = 1;
         edtEspectaculoCiudadNombre_Jsonclick = "";
         edtEspectaculoCiudadNombre_Enabled = 0;
         imgprompt_22_Visible = 1;
         imgprompt_22_Link = "";
         edtEspectaculoCiudadId_Jsonclick = "";
         edtEspectaculoCiudadId_Enabled = 1;
         imgEspectaculoPaisBandera_Enabled = 0;
         edtEspectaculoPaisNombre_Jsonclick = "";
         edtEspectaculoPaisNombre_Enabled = 0;
         imgprompt_19_Visible = 1;
         imgprompt_19_Link = "";
         edtEspectaculoPaisId_Jsonclick = "";
         edtEspectaculoPaisId_Enabled = 1;
         edtTipoEspectaculoNombre_Jsonclick = "";
         edtTipoEspectaculoNombre_Enabled = 0;
         imgprompt_6_Visible = 1;
         imgprompt_6_Link = "";
         edtTipoEspectaculoId_Jsonclick = "";
         edtTipoEspectaculoId_Enabled = 1;
         edtEspectaculoFecha_Jsonclick = "";
         edtEspectaculoFecha_Enabled = 1;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Enabled = 1;
         edtEspectaculoId_Jsonclick = "";
         edtEspectaculoId_Enabled = 1;
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

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_12814( ) ;
         while ( nGXsfl_128_idx <= nRC_GXsfl_128 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0514( ) ;
            standaloneModal0514( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0514( ) ;
            Grid1Row.AddGrid("Gridespectaculo_localidad_sector", Gridespectaculo_localidad_sectorContainer);
            nGXsfl_128_idx = (int)(nGXsfl_128_idx+1);
            sGXsfl_128_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_128_idx), 4, 0), 4, "0");
            SubsflControlProps_12814( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxnrGridespectaculo_localidad_sector_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS";
         AssignAttri("", false, "Gx_mode", Gx_mode);
         AssignAttri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         SubsflControlProps_17115( ) ;
         while ( nGXsfl_171_idx <= nRC_GXsfl_171 )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0514( ) ;
            standaloneModal0514( ) ;
            standaloneNotModal0515( ) ;
            standaloneModal0515( ) ;
            init_web_controls( ) ;
            dynload_actions( ) ;
            SendRow0515( ) ;
            nGXsfl_171_idx = (int)(nGXsfl_171_idx+1);
            sGXsfl_171_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_171_idx), 4, 0), 4, "0") + sGXsfl_128_idx;
            SubsflControlProps_17115( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Gridespectaculo_localidad_sectorContainer)) ;
         /* End function gxnrGridespectaculo_localidad_sector_newrow */
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

      public void Valid_Tipoespectaculoid( )
      {
         /* Using cursor T000527 */
         pr_default.execute(25, new Object[] {A6TipoEspectaculoId});
         if ( (pr_default.getStatus(25) == 101) )
         {
            GX_msglist.addItem("No matching 'Tipo Espectaculo'.", "ForeignKeyNotFound", 1, "TIPOESPECTACULOID");
            AnyError = 1;
            GX_FocusControl = edtTipoEspectaculoId_Internalname;
         }
         A7TipoEspectaculoNombre = T000527_A7TipoEspectaculoNombre[0];
         pr_default.close(25);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A7TipoEspectaculoNombre", StringUtil.RTrim( A7TipoEspectaculoNombre));
      }

      public void Valid_Espectaculopaisid( )
      {
         n40000EspectaculoPaisBandera_GXI = false;
         /* Using cursor T000528 */
         pr_default.execute(26, new Object[] {A19EspectaculoPaisId});
         if ( (pr_default.getStatus(26) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "ESPECTACULOPAISID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoPaisId_Internalname;
         }
         A20EspectaculoPaisNombre = T000528_A20EspectaculoPaisNombre[0];
         A40000EspectaculoPaisBandera_GXI = T000528_A40000EspectaculoPaisBandera_GXI[0];
         n40000EspectaculoPaisBandera_GXI = T000528_n40000EspectaculoPaisBandera_GXI[0];
         A21EspectaculoPaisBandera = T000528_A21EspectaculoPaisBandera[0];
         pr_default.close(26);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A20EspectaculoPaisNombre", StringUtil.RTrim( A20EspectaculoPaisNombre));
         AssignAttri("", false, "A21EspectaculoPaisBandera", context.PathToRelativeUrl( A21EspectaculoPaisBandera));
         AssignAttri("", false, "A40000EspectaculoPaisBandera_GXI", A40000EspectaculoPaisBandera_GXI);
      }

      public void Valid_Espectaculociudadid( )
      {
         /* Using cursor T000529 */
         pr_default.execute(27, new Object[] {A19EspectaculoPaisId, A22EspectaculoCiudadId});
         if ( (pr_default.getStatus(27) == 101) )
         {
            GX_msglist.addItem("No matching 'Espectaculo Pais'.", "ForeignKeyNotFound", 1, "ESPECTACULOPAISID");
            AnyError = 1;
            GX_FocusControl = edtEspectaculoPaisId_Internalname;
         }
         A23EspectaculoCiudadNombre = T000529_A23EspectaculoCiudadNombre[0];
         pr_default.close(27);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A23EspectaculoCiudadNombre", StringUtil.RTrim( A23EspectaculoCiudadNombre));
      }

      public void Valid_Lugarid( )
      {
         /* Using cursor T000530 */
         pr_default.execute(28, new Object[] {A8LugarId});
         if ( (pr_default.getStatus(28) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar'.", "ForeignKeyNotFound", 1, "LUGARID");
            AnyError = 1;
            GX_FocusControl = edtLugarId_Internalname;
         }
         A9LugarNombre = T000530_A9LugarNombre[0];
         A40001LugarFoto_GXI = T000530_A40001LugarFoto_GXI[0];
         A10LugarFoto = T000530_A10LugarFoto[0];
         pr_default.close(28);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A9LugarNombre", StringUtil.RTrim( A9LugarNombre));
         AssignAttri("", false, "A10LugarFoto", context.PathToRelativeUrl( A10LugarFoto));
         AssignAttri("", false, "A40001LugarFoto_GXI", A40001LugarFoto_GXI);
      }

      public void Valid_Lugarpaisid( )
      {
         n40002LugarPaisBandera_GXI = false;
         /* Using cursor T000531 */
         pr_default.execute(29, new Object[] {A29LugarPaisId});
         if ( (pr_default.getStatus(29) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar Pais'.", "ForeignKeyNotFound", 1, "LUGARPAISID");
            AnyError = 1;
            GX_FocusControl = edtLugarPaisId_Internalname;
         }
         A30LugarPaisNombre = T000531_A30LugarPaisNombre[0];
         A40002LugarPaisBandera_GXI = T000531_A40002LugarPaisBandera_GXI[0];
         n40002LugarPaisBandera_GXI = T000531_n40002LugarPaisBandera_GXI[0];
         A31LugarPaisBandera = T000531_A31LugarPaisBandera[0];
         pr_default.close(29);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A30LugarPaisNombre", StringUtil.RTrim( A30LugarPaisNombre));
         AssignAttri("", false, "A31LugarPaisBandera", context.PathToRelativeUrl( A31LugarPaisBandera));
         AssignAttri("", false, "A40002LugarPaisBandera_GXI", A40002LugarPaisBandera_GXI);
      }

      public void Valid_Lugarciudadid( )
      {
         /* Using cursor T000532 */
         pr_default.execute(30, new Object[] {A29LugarPaisId, A32LugarCiudadId});
         if ( (pr_default.getStatus(30) == 101) )
         {
            GX_msglist.addItem("No matching 'Lugar Pais'.", "ForeignKeyNotFound", 1, "LUGARPAISID");
            AnyError = 1;
            GX_FocusControl = edtLugarPaisId_Internalname;
         }
         A33LugarCiudadNombre = T000532_A33LugarCiudadNombre[0];
         pr_default.close(30);
         dynload_actions( ) ;
         /*  Sending validation outputs */
         AssignAttri("", false, "A33LugarCiudadNombre", StringUtil.RTrim( A33LugarCiudadNombre));
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV19EspectaculoId',fld:'vESPECTACULOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true},{av:'AV19EspectaculoId',fld:'vESPECTACULOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12052',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV9TrnContext',fld:'vTRNCONTEXT',pic:'',hsh:true}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOID","{handler:'Valid_Espectaculoid',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOID",",oparms:[]}");
         setEventMetadata("VALID_ESPECTACULOFECHA","{handler:'Valid_Espectaculofecha',iparms:[]");
         setEventMetadata("VALID_ESPECTACULOFECHA",",oparms:[]}");
         setEventMetadata("VALID_TIPOESPECTACULOID","{handler:'Valid_Tipoespectaculoid',iparms:[{av:'A6TipoEspectaculoId',fld:'TIPOESPECTACULOID',pic:'ZZZ9'},{av:'A7TipoEspectaculoNombre',fld:'TIPOESPECTACULONOMBRE',pic:''}]");
         setEventMetadata("VALID_TIPOESPECTACULOID",",oparms:[{av:'A7TipoEspectaculoNombre',fld:'TIPOESPECTACULONOMBRE',pic:''}]}");
         setEventMetadata("VALID_ESPECTACULOPAISID","{handler:'Valid_Espectaculopaisid',iparms:[{av:'A19EspectaculoPaisId',fld:'ESPECTACULOPAISID',pic:'ZZZ9'},{av:'A20EspectaculoPaisNombre',fld:'ESPECTACULOPAISNOMBRE',pic:''},{av:'A21EspectaculoPaisBandera',fld:'ESPECTACULOPAISBANDERA',pic:''},{av:'A40000EspectaculoPaisBandera_GXI',fld:'ESPECTACULOPAISBANDERA_GXI',pic:''}]");
         setEventMetadata("VALID_ESPECTACULOPAISID",",oparms:[{av:'A20EspectaculoPaisNombre',fld:'ESPECTACULOPAISNOMBRE',pic:''},{av:'A21EspectaculoPaisBandera',fld:'ESPECTACULOPAISBANDERA',pic:''},{av:'A40000EspectaculoPaisBandera_GXI',fld:'ESPECTACULOPAISBANDERA_GXI',pic:''}]}");
         setEventMetadata("VALID_ESPECTACULOCIUDADID","{handler:'Valid_Espectaculociudadid',iparms:[{av:'A19EspectaculoPaisId',fld:'ESPECTACULOPAISID',pic:'ZZZ9'},{av:'A22EspectaculoCiudadId',fld:'ESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'A23EspectaculoCiudadNombre',fld:'ESPECTACULOCIUDADNOMBRE',pic:''}]");
         setEventMetadata("VALID_ESPECTACULOCIUDADID",",oparms:[{av:'A23EspectaculoCiudadNombre',fld:'ESPECTACULOCIUDADNOMBRE',pic:''}]}");
         setEventMetadata("VALID_LUGARID","{handler:'Valid_Lugarid',iparms:[{av:'A8LugarId',fld:'LUGARID',pic:'ZZZ9'},{av:'A9LugarNombre',fld:'LUGARNOMBRE',pic:''},{av:'A10LugarFoto',fld:'LUGARFOTO',pic:''},{av:'A40001LugarFoto_GXI',fld:'LUGARFOTO_GXI',pic:''}]");
         setEventMetadata("VALID_LUGARID",",oparms:[{av:'A9LugarNombre',fld:'LUGARNOMBRE',pic:''},{av:'A10LugarFoto',fld:'LUGARFOTO',pic:''},{av:'A40001LugarFoto_GXI',fld:'LUGARFOTO_GXI',pic:''}]}");
         setEventMetadata("VALID_LUGARPAISID","{handler:'Valid_Lugarpaisid',iparms:[{av:'A29LugarPaisId',fld:'LUGARPAISID',pic:'ZZZ9'},{av:'A30LugarPaisNombre',fld:'LUGARPAISNOMBRE',pic:''},{av:'A31LugarPaisBandera',fld:'LUGARPAISBANDERA',pic:''},{av:'A40002LugarPaisBandera_GXI',fld:'LUGARPAISBANDERA_GXI',pic:''}]");
         setEventMetadata("VALID_LUGARPAISID",",oparms:[{av:'A30LugarPaisNombre',fld:'LUGARPAISNOMBRE',pic:''},{av:'A31LugarPaisBandera',fld:'LUGARPAISBANDERA',pic:''},{av:'A40002LugarPaisBandera_GXI',fld:'LUGARPAISBANDERA_GXI',pic:''}]}");
         setEventMetadata("VALID_LUGARCIUDADID","{handler:'Valid_Lugarciudadid',iparms:[{av:'A29LugarPaisId',fld:'LUGARPAISID',pic:'ZZZ9'},{av:'A32LugarCiudadId',fld:'LUGARCIUDADID',pic:'ZZZ9'},{av:'A33LugarCiudadNombre',fld:'LUGARCIUDADNOMBRE',pic:''}]");
         setEventMetadata("VALID_LUGARCIUDADID",",oparms:[{av:'A33LugarCiudadNombre',fld:'LUGARCIUDADNOMBRE',pic:''}]}");
         setEventMetadata("VALID_LOCALIDADID","{handler:'Valid_Localidadid',iparms:[]");
         setEventMetadata("VALID_LOCALIDADID",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Localidadesdisponibles',iparms:[]");
         setEventMetadata("NULL",",oparms:[]}");
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
         pr_default.close(5);
         pr_default.close(28);
         pr_default.close(25);
         pr_default.close(26);
         pr_default.close(29);
         pr_default.close(27);
         pr_default.close(30);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z35EspectaculoNombre = "";
         Z36EspectaculoFecha = DateTime.MinValue;
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
         A35EspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         sImgUrl = "";
         A7TipoEspectaculoNombre = "";
         A20EspectaculoPaisNombre = "";
         A21EspectaculoPaisBandera = "";
         A40000EspectaculoPaisBandera_GXI = "";
         A23EspectaculoCiudadNombre = "";
         A9LugarNombre = "";
         A10LugarFoto = "";
         A40001LugarFoto_GXI = "";
         A30LugarPaisNombre = "";
         A31LugarPaisBandera = "";
         A40002LugarPaisBandera_GXI = "";
         A33LugarCiudadNombre = "";
         lblTitlelocalidad_Jsonclick = "";
         bttBtn_enter_Jsonclick = "";
         bttBtn_cancel_Jsonclick = "";
         bttBtn_delete_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         subGrid1_Header = "";
         Grid1Column = new GXWebColumn();
         A12LocalidadNombre = "";
         sMode14 = "";
         sStyleString = "";
         AV20Pgmname = "";
         forbiddenHiddens = new GXProperties();
         hsh = "";
         sMode7 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         GXCCtl = "";
         A18SectorNombre = "";
         AV9TrnContext = new SdtTransactionContext(context);
         AV10WebSession = context.GetSession();
         AV18TrnContextAtt = new SdtTransactionContext_Attribute(context);
         Z7TipoEspectaculoNombre = "";
         Z20EspectaculoPaisNombre = "";
         Z21EspectaculoPaisBandera = "";
         Z40000EspectaculoPaisBandera_GXI = "";
         Z23EspectaculoCiudadNombre = "";
         Z9LugarNombre = "";
         Z10LugarFoto = "";
         Z40001LugarFoto_GXI = "";
         Z30LugarPaisNombre = "";
         Z31LugarPaisBandera = "";
         Z40002LugarPaisBandera_GXI = "";
         Z33LugarCiudadNombre = "";
         T000511_A30LugarPaisNombre = new String[] {""} ;
         T000511_A40002LugarPaisBandera_GXI = new String[] {""} ;
         T000511_n40002LugarPaisBandera_GXI = new bool[] {false} ;
         T000511_A31LugarPaisBandera = new String[] {""} ;
         T000513_A33LugarCiudadNombre = new String[] {""} ;
         T00058_A9LugarNombre = new String[] {""} ;
         T00058_A40001LugarFoto_GXI = new String[] {""} ;
         T00058_A10LugarFoto = new String[] {""} ;
         T000510_A20EspectaculoPaisNombre = new String[] {""} ;
         T000510_A40000EspectaculoPaisBandera_GXI = new String[] {""} ;
         T000510_n40000EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T000510_A21EspectaculoPaisBandera = new String[] {""} ;
         T000512_A23EspectaculoCiudadNombre = new String[] {""} ;
         T00059_A7TipoEspectaculoNombre = new String[] {""} ;
         T000514_A34EspectaculoId = new short[1] ;
         T000514_A35EspectaculoNombre = new String[] {""} ;
         T000514_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T000514_A7TipoEspectaculoNombre = new String[] {""} ;
         T000514_A20EspectaculoPaisNombre = new String[] {""} ;
         T000514_A40000EspectaculoPaisBandera_GXI = new String[] {""} ;
         T000514_n40000EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T000514_A23EspectaculoCiudadNombre = new String[] {""} ;
         T000514_A9LugarNombre = new String[] {""} ;
         T000514_A40001LugarFoto_GXI = new String[] {""} ;
         T000514_A30LugarPaisNombre = new String[] {""} ;
         T000514_A40002LugarPaisBandera_GXI = new String[] {""} ;
         T000514_n40002LugarPaisBandera_GXI = new bool[] {false} ;
         T000514_A33LugarCiudadNombre = new String[] {""} ;
         T000514_A8LugarId = new short[1] ;
         T000514_A6TipoEspectaculoId = new short[1] ;
         T000514_A19EspectaculoPaisId = new short[1] ;
         T000514_A29LugarPaisId = new short[1] ;
         T000514_A22EspectaculoCiudadId = new short[1] ;
         T000514_A32LugarCiudadId = new short[1] ;
         T000514_A21EspectaculoPaisBandera = new String[] {""} ;
         T000514_A10LugarFoto = new String[] {""} ;
         T000514_A31LugarPaisBandera = new String[] {""} ;
         T000515_A7TipoEspectaculoNombre = new String[] {""} ;
         T000516_A20EspectaculoPaisNombre = new String[] {""} ;
         T000516_A40000EspectaculoPaisBandera_GXI = new String[] {""} ;
         T000516_n40000EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T000516_A21EspectaculoPaisBandera = new String[] {""} ;
         T000517_A23EspectaculoCiudadNombre = new String[] {""} ;
         T000518_A9LugarNombre = new String[] {""} ;
         T000518_A40001LugarFoto_GXI = new String[] {""} ;
         T000518_A10LugarFoto = new String[] {""} ;
         T000519_A30LugarPaisNombre = new String[] {""} ;
         T000519_A40002LugarPaisBandera_GXI = new String[] {""} ;
         T000519_n40002LugarPaisBandera_GXI = new bool[] {false} ;
         T000519_A31LugarPaisBandera = new String[] {""} ;
         T000520_A33LugarCiudadNombre = new String[] {""} ;
         T000521_A34EspectaculoId = new short[1] ;
         T00057_A34EspectaculoId = new short[1] ;
         T00057_A35EspectaculoNombre = new String[] {""} ;
         T00057_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T00057_A8LugarId = new short[1] ;
         T00057_A6TipoEspectaculoId = new short[1] ;
         T00057_A19EspectaculoPaisId = new short[1] ;
         T00057_A29LugarPaisId = new short[1] ;
         T00057_A22EspectaculoCiudadId = new short[1] ;
         T00057_A32LugarCiudadId = new short[1] ;
         T000522_A34EspectaculoId = new short[1] ;
         T000523_A34EspectaculoId = new short[1] ;
         T00056_A34EspectaculoId = new short[1] ;
         T00056_A35EspectaculoNombre = new String[] {""} ;
         T00056_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         T00056_A8LugarId = new short[1] ;
         T00056_A6TipoEspectaculoId = new short[1] ;
         T00056_A19EspectaculoPaisId = new short[1] ;
         T00056_A29LugarPaisId = new short[1] ;
         T00056_A22EspectaculoCiudadId = new short[1] ;
         T00056_A32LugarCiudadId = new short[1] ;
         T000527_A7TipoEspectaculoNombre = new String[] {""} ;
         T000528_A20EspectaculoPaisNombre = new String[] {""} ;
         T000528_A40000EspectaculoPaisBandera_GXI = new String[] {""} ;
         T000528_n40000EspectaculoPaisBandera_GXI = new bool[] {false} ;
         T000528_A21EspectaculoPaisBandera = new String[] {""} ;
         T000529_A23EspectaculoCiudadNombre = new String[] {""} ;
         T000530_A9LugarNombre = new String[] {""} ;
         T000530_A40001LugarFoto_GXI = new String[] {""} ;
         T000530_A10LugarFoto = new String[] {""} ;
         T000531_A30LugarPaisNombre = new String[] {""} ;
         T000531_A40002LugarPaisBandera_GXI = new String[] {""} ;
         T000531_n40002LugarPaisBandera_GXI = new bool[] {false} ;
         T000531_A31LugarPaisBandera = new String[] {""} ;
         T000532_A33LugarCiudadNombre = new String[] {""} ;
         T000533_A37VentaId = new short[1] ;
         T000534_A34EspectaculoId = new short[1] ;
         T000534_A11LocalidadId = new short[1] ;
         T000535_A34EspectaculoId = new short[1] ;
         T000536_A34EspectaculoId = new short[1] ;
         T000536_A11LocalidadId = new short[1] ;
         T000536_A12LocalidadNombre = new String[] {""} ;
         T000536_A13LocalidadCapacidad = new int[1] ;
         T000536_A14LocalidadPrecio = new decimal[1] ;
         T000536_A15LocalidadesVendidas = new int[1] ;
         T000536_A16LocalidadesDisponibles = new int[1] ;
         T000537_A34EspectaculoId = new short[1] ;
         T000537_A11LocalidadId = new short[1] ;
         T00055_A34EspectaculoId = new short[1] ;
         T00055_A11LocalidadId = new short[1] ;
         T00055_A12LocalidadNombre = new String[] {""} ;
         T00055_A13LocalidadCapacidad = new int[1] ;
         T00055_A14LocalidadPrecio = new decimal[1] ;
         T00055_A15LocalidadesVendidas = new int[1] ;
         T00055_A16LocalidadesDisponibles = new int[1] ;
         T00054_A34EspectaculoId = new short[1] ;
         T00054_A11LocalidadId = new short[1] ;
         T00054_A12LocalidadNombre = new String[] {""} ;
         T00054_A13LocalidadCapacidad = new int[1] ;
         T00054_A14LocalidadPrecio = new decimal[1] ;
         T00054_A15LocalidadesVendidas = new int[1] ;
         T00054_A16LocalidadesDisponibles = new int[1] ;
         T000541_A34EspectaculoId = new short[1] ;
         T000541_A11LocalidadId = new short[1] ;
         T000542_A34EspectaculoId = new short[1] ;
         T000542_A11LocalidadId = new short[1] ;
         T000542_A17SectorId = new short[1] ;
         T000542_A18SectorNombre = new String[] {""} ;
         T000543_A34EspectaculoId = new short[1] ;
         T000543_A11LocalidadId = new short[1] ;
         T000543_A17SectorId = new short[1] ;
         T00053_A34EspectaculoId = new short[1] ;
         T00053_A11LocalidadId = new short[1] ;
         T00053_A17SectorId = new short[1] ;
         T00053_A18SectorNombre = new String[] {""} ;
         sMode15 = "";
         T00052_A34EspectaculoId = new short[1] ;
         T00052_A11LocalidadId = new short[1] ;
         T00052_A17SectorId = new short[1] ;
         T00052_A18SectorNombre = new String[] {""} ;
         T000547_A34EspectaculoId = new short[1] ;
         T000547_A11LocalidadId = new short[1] ;
         T000547_A17SectorId = new short[1] ;
         Grid1Row = new GXWebRow();
         subGrid1_Linesclass = "";
         ROClassString = "";
         lblTitlesector_Jsonclick = "";
         Gridespectaculo_localidad_sectorContainer = new GXWebGrid( context);
         Gridespectaculo_localidad_sectorColumn = new GXWebColumn();
         Gridespectaculo_localidad_sectorRow = new GXWebRow();
         subGridespectaculo_localidad_sector_Linesclass = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXCCtlgxBlob = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.espectaculo__default(),
            new Object[][] {
                new Object[] {
               T00052_A34EspectaculoId, T00052_A11LocalidadId, T00052_A17SectorId, T00052_A18SectorNombre
               }
               , new Object[] {
               T00053_A34EspectaculoId, T00053_A11LocalidadId, T00053_A17SectorId, T00053_A18SectorNombre
               }
               , new Object[] {
               T00054_A34EspectaculoId, T00054_A11LocalidadId, T00054_A12LocalidadNombre, T00054_A13LocalidadCapacidad, T00054_A14LocalidadPrecio, T00054_A15LocalidadesVendidas, T00054_A16LocalidadesDisponibles
               }
               , new Object[] {
               T00055_A34EspectaculoId, T00055_A11LocalidadId, T00055_A12LocalidadNombre, T00055_A13LocalidadCapacidad, T00055_A14LocalidadPrecio, T00055_A15LocalidadesVendidas, T00055_A16LocalidadesDisponibles
               }
               , new Object[] {
               T00056_A34EspectaculoId, T00056_A35EspectaculoNombre, T00056_A36EspectaculoFecha, T00056_A8LugarId, T00056_A6TipoEspectaculoId, T00056_A19EspectaculoPaisId, T00056_A29LugarPaisId, T00056_A22EspectaculoCiudadId, T00056_A32LugarCiudadId
               }
               , new Object[] {
               T00057_A34EspectaculoId, T00057_A35EspectaculoNombre, T00057_A36EspectaculoFecha, T00057_A8LugarId, T00057_A6TipoEspectaculoId, T00057_A19EspectaculoPaisId, T00057_A29LugarPaisId, T00057_A22EspectaculoCiudadId, T00057_A32LugarCiudadId
               }
               , new Object[] {
               T00058_A9LugarNombre, T00058_A40001LugarFoto_GXI, T00058_A10LugarFoto
               }
               , new Object[] {
               T00059_A7TipoEspectaculoNombre
               }
               , new Object[] {
               T000510_A20EspectaculoPaisNombre, T000510_A40000EspectaculoPaisBandera_GXI, T000510_n40000EspectaculoPaisBandera_GXI, T000510_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T000511_A30LugarPaisNombre, T000511_A40002LugarPaisBandera_GXI, T000511_n40002LugarPaisBandera_GXI, T000511_A31LugarPaisBandera
               }
               , new Object[] {
               T000512_A23EspectaculoCiudadNombre
               }
               , new Object[] {
               T000513_A33LugarCiudadNombre
               }
               , new Object[] {
               T000514_A34EspectaculoId, T000514_A35EspectaculoNombre, T000514_A36EspectaculoFecha, T000514_A7TipoEspectaculoNombre, T000514_A20EspectaculoPaisNombre, T000514_A40000EspectaculoPaisBandera_GXI, T000514_n40000EspectaculoPaisBandera_GXI, T000514_A23EspectaculoCiudadNombre, T000514_A9LugarNombre, T000514_A40001LugarFoto_GXI,
               T000514_A30LugarPaisNombre, T000514_A40002LugarPaisBandera_GXI, T000514_n40002LugarPaisBandera_GXI, T000514_A33LugarCiudadNombre, T000514_A8LugarId, T000514_A6TipoEspectaculoId, T000514_A19EspectaculoPaisId, T000514_A29LugarPaisId, T000514_A22EspectaculoCiudadId, T000514_A32LugarCiudadId,
               T000514_A21EspectaculoPaisBandera, T000514_A10LugarFoto, T000514_A31LugarPaisBandera
               }
               , new Object[] {
               T000515_A7TipoEspectaculoNombre
               }
               , new Object[] {
               T000516_A20EspectaculoPaisNombre, T000516_A40000EspectaculoPaisBandera_GXI, T000516_n40000EspectaculoPaisBandera_GXI, T000516_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T000517_A23EspectaculoCiudadNombre
               }
               , new Object[] {
               T000518_A9LugarNombre, T000518_A40001LugarFoto_GXI, T000518_A10LugarFoto
               }
               , new Object[] {
               T000519_A30LugarPaisNombre, T000519_A40002LugarPaisBandera_GXI, T000519_n40002LugarPaisBandera_GXI, T000519_A31LugarPaisBandera
               }
               , new Object[] {
               T000520_A33LugarCiudadNombre
               }
               , new Object[] {
               T000521_A34EspectaculoId
               }
               , new Object[] {
               T000522_A34EspectaculoId
               }
               , new Object[] {
               T000523_A34EspectaculoId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000527_A7TipoEspectaculoNombre
               }
               , new Object[] {
               T000528_A20EspectaculoPaisNombre, T000528_A40000EspectaculoPaisBandera_GXI, T000528_n40000EspectaculoPaisBandera_GXI, T000528_A21EspectaculoPaisBandera
               }
               , new Object[] {
               T000529_A23EspectaculoCiudadNombre
               }
               , new Object[] {
               T000530_A9LugarNombre, T000530_A40001LugarFoto_GXI, T000530_A10LugarFoto
               }
               , new Object[] {
               T000531_A30LugarPaisNombre, T000531_A40002LugarPaisBandera_GXI, T000531_n40002LugarPaisBandera_GXI, T000531_A31LugarPaisBandera
               }
               , new Object[] {
               T000532_A33LugarCiudadNombre
               }
               , new Object[] {
               T000533_A37VentaId
               }
               , new Object[] {
               T000534_A34EspectaculoId, T000534_A11LocalidadId
               }
               , new Object[] {
               T000535_A34EspectaculoId
               }
               , new Object[] {
               T000536_A34EspectaculoId, T000536_A11LocalidadId, T000536_A12LocalidadNombre, T000536_A13LocalidadCapacidad, T000536_A14LocalidadPrecio, T000536_A15LocalidadesVendidas, T000536_A16LocalidadesDisponibles
               }
               , new Object[] {
               T000537_A34EspectaculoId, T000537_A11LocalidadId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000541_A34EspectaculoId, T000541_A11LocalidadId
               }
               , new Object[] {
               T000542_A34EspectaculoId, T000542_A11LocalidadId, T000542_A17SectorId, T000542_A18SectorNombre
               }
               , new Object[] {
               T000543_A34EspectaculoId, T000543_A11LocalidadId, T000543_A17SectorId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000547_A34EspectaculoId, T000547_A11LocalidadId, T000547_A17SectorId
               }
            }
         );
         AV20Pgmname = "Espectaculo";
      }

      private short wcpOAV19EspectaculoId ;
      private short Z34EspectaculoId ;
      private short Z8LugarId ;
      private short Z6TipoEspectaculoId ;
      private short Z19EspectaculoPaisId ;
      private short Z29LugarPaisId ;
      private short Z22EspectaculoCiudadId ;
      private short Z32LugarCiudadId ;
      private short N6TipoEspectaculoId ;
      private short N19EspectaculoPaisId ;
      private short N22EspectaculoCiudadId ;
      private short N8LugarId ;
      private short N29LugarPaisId ;
      private short N32LugarCiudadId ;
      private short Z11LocalidadId ;
      private short nRcdDeleted_14 ;
      private short nRcdExists_14 ;
      private short nIsMod_14 ;
      private short Z17SectorId ;
      private short nRcdDeleted_15 ;
      private short nRcdExists_15 ;
      private short nIsMod_15 ;
      private short GxWebError ;
      private short A6TipoEspectaculoId ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short A8LugarId ;
      private short A29LugarPaisId ;
      private short A32LugarCiudadId ;
      private short AV19EspectaculoId ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A34EspectaculoId ;
      private short subGrid1_Backcolorstyle ;
      private short A11LocalidadId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nBlankRcdCount14 ;
      private short RcdFound14 ;
      private short nBlankRcdUsr14 ;
      private short AV11Insert_TipoEspectaculoId ;
      private short AV12Insert_EspectaculoPaisId ;
      private short AV13Insert_EspectaculoCiudadId ;
      private short AV14Insert_LugarId ;
      private short AV15Insert_LugarPaisId ;
      private short AV16Insert_LugarCiudadId ;
      private short RcdFound7 ;
      private short RcdFound15 ;
      private short A17SectorId ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short nIsDirty_7 ;
      private short nIsDirty_14 ;
      private short nIsDirty_15 ;
      private short subGrid1_Backstyle ;
      private short subGridespectaculo_localidad_sector_Backcolorstyle ;
      private short subGridespectaculo_localidad_sector_Allowselection ;
      private short subGridespectaculo_localidad_sector_Allowhovering ;
      private short subGridespectaculo_localidad_sector_Allowcollapsing ;
      private short subGridespectaculo_localidad_sector_Collapsed ;
      private short nBlankRcdCount15 ;
      private short nBlankRcdUsr15 ;
      private short subGridespectaculo_localidad_sector_Backstyle ;
      private short gxajaxcallmode ;
      private int nRC_GXsfl_128 ;
      private int nGXsfl_128_idx=1 ;
      private int Z13LocalidadCapacidad ;
      private int Z15LocalidadesVendidas ;
      private int Z16LocalidadesDisponibles ;
      private int nRC_GXsfl_171 ;
      private int nGXsfl_171_idx=1 ;
      private int trnEnded ;
      private int bttBtn_first_Visible ;
      private int bttBtn_previous_Visible ;
      private int bttBtn_next_Visible ;
      private int bttBtn_last_Visible ;
      private int bttBtn_select_Visible ;
      private int edtEspectaculoId_Enabled ;
      private int edtEspectaculoNombre_Enabled ;
      private int edtEspectaculoFecha_Enabled ;
      private int edtTipoEspectaculoId_Enabled ;
      private int imgprompt_6_Visible ;
      private int edtTipoEspectaculoNombre_Enabled ;
      private int edtEspectaculoPaisId_Enabled ;
      private int imgprompt_19_Visible ;
      private int edtEspectaculoPaisNombre_Enabled ;
      private int imgEspectaculoPaisBandera_Enabled ;
      private int edtEspectaculoCiudadId_Enabled ;
      private int imgprompt_22_Visible ;
      private int edtEspectaculoCiudadNombre_Enabled ;
      private int edtLugarId_Enabled ;
      private int imgprompt_8_Visible ;
      private int edtLugarNombre_Enabled ;
      private int imgLugarFoto_Enabled ;
      private int edtLugarPaisId_Enabled ;
      private int imgprompt_29_Visible ;
      private int edtLugarPaisNombre_Enabled ;
      private int imgLugarPaisBandera_Enabled ;
      private int edtLugarCiudadId_Enabled ;
      private int imgprompt_32_Visible ;
      private int edtLugarCiudadNombre_Enabled ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_enter_Enabled ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int bttBtn_delete_Enabled ;
      private int edtLocalidadId_Enabled ;
      private int edtLocalidadNombre_Enabled ;
      private int A13LocalidadCapacidad ;
      private int edtLocalidadCapacidad_Enabled ;
      private int edtLocalidadPrecio_Enabled ;
      private int A15LocalidadesVendidas ;
      private int edtLocalidadesVendidas_Enabled ;
      private int A16LocalidadesDisponibles ;
      private int edtLocalidadesDisponibles_Enabled ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int fRowAdded ;
      private int edtSectorId_Enabled ;
      private int edtSectorNombre_Enabled ;
      private int AV21GXV1 ;
      private int subGrid1_Backcolor ;
      private int subGrid1_Allbackcolor ;
      private int GRID1_IsPaging ;
      private int subGridespectaculo_localidad_sector_Selectedindex ;
      private int subGridespectaculo_localidad_sector_Selectioncolor ;
      private int subGridespectaculo_localidad_sector_Hoveringcolor ;
      private int subGridespectaculo_localidad_sector_Backcolor ;
      private int subGridespectaculo_localidad_sector_Allbackcolor ;
      private int defedtSectorId_Enabled ;
      private int defedtLocalidadId_Enabled ;
      private int idxLst ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRIDESPECTACULO_LOCALIDAD_SECTOR_nFirstRecordOnPage ;
      private long GRIDESPECTACULO_LOCALIDAD_SECTOR_nCurrentRecord ;
      private decimal Z14LocalidadPrecio ;
      private decimal A14LocalidadPrecio ;
      private String sPrefix ;
      private String wcpOGx_mode ;
      private String Z35EspectaculoNombre ;
      private String Z12LocalidadNombre ;
      private String Z18SectorNombre ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_171_idx="0001" ;
      private String Gx_mode ;
      private String sGXsfl_128_idx="0001" ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtEspectaculoId_Internalname ;
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
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Internalname ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoFecha_Internalname ;
      private String edtEspectaculoFecha_Jsonclick ;
      private String edtTipoEspectaculoId_Internalname ;
      private String edtTipoEspectaculoId_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_6_Internalname ;
      private String imgprompt_6_Link ;
      private String edtTipoEspectaculoNombre_Internalname ;
      private String A7TipoEspectaculoNombre ;
      private String edtTipoEspectaculoNombre_Jsonclick ;
      private String edtEspectaculoPaisId_Internalname ;
      private String edtEspectaculoPaisId_Jsonclick ;
      private String imgprompt_19_Internalname ;
      private String imgprompt_19_Link ;
      private String edtEspectaculoPaisNombre_Internalname ;
      private String A20EspectaculoPaisNombre ;
      private String edtEspectaculoPaisNombre_Jsonclick ;
      private String imgEspectaculoPaisBandera_Internalname ;
      private String edtEspectaculoCiudadId_Internalname ;
      private String edtEspectaculoCiudadId_Jsonclick ;
      private String imgprompt_22_Internalname ;
      private String imgprompt_22_Link ;
      private String edtEspectaculoCiudadNombre_Internalname ;
      private String A23EspectaculoCiudadNombre ;
      private String edtEspectaculoCiudadNombre_Jsonclick ;
      private String edtLugarId_Internalname ;
      private String edtLugarId_Jsonclick ;
      private String imgprompt_8_Internalname ;
      private String imgprompt_8_Link ;
      private String edtLugarNombre_Internalname ;
      private String A9LugarNombre ;
      private String edtLugarNombre_Jsonclick ;
      private String imgLugarFoto_Internalname ;
      private String edtLugarPaisId_Internalname ;
      private String edtLugarPaisId_Jsonclick ;
      private String imgprompt_29_Internalname ;
      private String imgprompt_29_Link ;
      private String edtLugarPaisNombre_Internalname ;
      private String A30LugarPaisNombre ;
      private String edtLugarPaisNombre_Jsonclick ;
      private String imgLugarPaisBandera_Internalname ;
      private String edtLugarCiudadId_Internalname ;
      private String edtLugarCiudadId_Jsonclick ;
      private String imgprompt_32_Internalname ;
      private String imgprompt_32_Link ;
      private String edtLugarCiudadNombre_Internalname ;
      private String A33LugarCiudadNombre ;
      private String edtLugarCiudadNombre_Jsonclick ;
      private String divLocalidadtable_Internalname ;
      private String lblTitlelocalidad_Internalname ;
      private String lblTitlelocalidad_Jsonclick ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String subGrid1_Header ;
      private String A12LocalidadNombre ;
      private String lblTitlesector_Caption ;
      private String sMode14 ;
      private String edtLocalidadId_Internalname ;
      private String edtLocalidadNombre_Internalname ;
      private String edtLocalidadCapacidad_Internalname ;
      private String edtLocalidadPrecio_Internalname ;
      private String edtLocalidadesVendidas_Internalname ;
      private String edtLocalidadesDisponibles_Internalname ;
      private String sStyleString ;
      private String AV20Pgmname ;
      private String hsh ;
      private String sMode7 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXCCtl ;
      private String edtSectorId_Internalname ;
      private String edtSectorNombre_Internalname ;
      private String A18SectorNombre ;
      private String Z7TipoEspectaculoNombre ;
      private String Z20EspectaculoPaisNombre ;
      private String Z23EspectaculoCiudadNombre ;
      private String Z9LugarNombre ;
      private String Z30LugarPaisNombre ;
      private String Z33LugarCiudadNombre ;
      private String sMode15 ;
      private String lblTitlesector_Internalname ;
      private String subGridespectaculo_localidad_sector_Internalname ;
      private String sGXsfl_128_fel_idx="0001" ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String divGridtable1_Internalname ;
      private String divTable2_Internalname ;
      private String ROClassString ;
      private String edtLocalidadId_Jsonclick ;
      private String edtLocalidadNombre_Jsonclick ;
      private String edtLocalidadCapacidad_Jsonclick ;
      private String edtLocalidadPrecio_Jsonclick ;
      private String edtLocalidadesVendidas_Jsonclick ;
      private String edtLocalidadesDisponibles_Jsonclick ;
      private String divSectortable_Internalname ;
      private String lblTitlesector_Jsonclick ;
      private String subGridespectaculo_localidad_sector_Header ;
      private String sGXsfl_171_fel_idx="0001" ;
      private String subGridespectaculo_localidad_sector_Class ;
      private String subGridespectaculo_localidad_sector_Linesclass ;
      private String edtSectorId_Jsonclick ;
      private String edtSectorNombre_Jsonclick ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXCCtlgxBlob ;
      private String subGrid1_Internalname ;
      private DateTime Z36EspectaculoFecha ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool A21EspectaculoPaisBandera_IsBlob ;
      private bool A10LugarFoto_IsBlob ;
      private bool A31LugarPaisBandera_IsBlob ;
      private bool bGXsfl_128_Refreshing=false ;
      private bool returnInSub ;
      private bool n40002LugarPaisBandera_GXI ;
      private bool n40000EspectaculoPaisBandera_GXI ;
      private bool Gx_longc ;
      private bool bGXsfl_171_Refreshing=false ;
      private String A40000EspectaculoPaisBandera_GXI ;
      private String A40001LugarFoto_GXI ;
      private String A40002LugarPaisBandera_GXI ;
      private String Z40000EspectaculoPaisBandera_GXI ;
      private String Z40001LugarFoto_GXI ;
      private String Z40002LugarPaisBandera_GXI ;
      private String A21EspectaculoPaisBandera ;
      private String A10LugarFoto ;
      private String A31LugarPaisBandera ;
      private String Z21EspectaculoPaisBandera ;
      private String Z10LugarFoto ;
      private String Z31LugarPaisBandera ;
      private IGxSession AV10WebSession ;
      private GXProperties forbiddenHiddens ;
      private GXWebGrid Grid1Container ;
      private GXWebGrid Gridespectaculo_localidad_sectorContainer ;
      private GXWebRow Grid1Row ;
      private GXWebRow Gridespectaculo_localidad_sectorRow ;
      private GXWebColumn Grid1Column ;
      private GXWebColumn Gridespectaculo_localidad_sectorColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] T000511_A30LugarPaisNombre ;
      private String[] T000511_A40002LugarPaisBandera_GXI ;
      private bool[] T000511_n40002LugarPaisBandera_GXI ;
      private String[] T000511_A31LugarPaisBandera ;
      private String[] T000513_A33LugarCiudadNombre ;
      private String[] T00058_A9LugarNombre ;
      private String[] T00058_A40001LugarFoto_GXI ;
      private String[] T00058_A10LugarFoto ;
      private String[] T000510_A20EspectaculoPaisNombre ;
      private String[] T000510_A40000EspectaculoPaisBandera_GXI ;
      private bool[] T000510_n40000EspectaculoPaisBandera_GXI ;
      private String[] T000510_A21EspectaculoPaisBandera ;
      private String[] T000512_A23EspectaculoCiudadNombre ;
      private String[] T00059_A7TipoEspectaculoNombre ;
      private short[] T000514_A34EspectaculoId ;
      private String[] T000514_A35EspectaculoNombre ;
      private DateTime[] T000514_A36EspectaculoFecha ;
      private String[] T000514_A7TipoEspectaculoNombre ;
      private String[] T000514_A20EspectaculoPaisNombre ;
      private String[] T000514_A40000EspectaculoPaisBandera_GXI ;
      private bool[] T000514_n40000EspectaculoPaisBandera_GXI ;
      private String[] T000514_A23EspectaculoCiudadNombre ;
      private String[] T000514_A9LugarNombre ;
      private String[] T000514_A40001LugarFoto_GXI ;
      private String[] T000514_A30LugarPaisNombre ;
      private String[] T000514_A40002LugarPaisBandera_GXI ;
      private bool[] T000514_n40002LugarPaisBandera_GXI ;
      private String[] T000514_A33LugarCiudadNombre ;
      private short[] T000514_A8LugarId ;
      private short[] T000514_A6TipoEspectaculoId ;
      private short[] T000514_A19EspectaculoPaisId ;
      private short[] T000514_A29LugarPaisId ;
      private short[] T000514_A22EspectaculoCiudadId ;
      private short[] T000514_A32LugarCiudadId ;
      private String[] T000514_A21EspectaculoPaisBandera ;
      private String[] T000514_A10LugarFoto ;
      private String[] T000514_A31LugarPaisBandera ;
      private String[] T000515_A7TipoEspectaculoNombre ;
      private String[] T000516_A20EspectaculoPaisNombre ;
      private String[] T000516_A40000EspectaculoPaisBandera_GXI ;
      private bool[] T000516_n40000EspectaculoPaisBandera_GXI ;
      private String[] T000516_A21EspectaculoPaisBandera ;
      private String[] T000517_A23EspectaculoCiudadNombre ;
      private String[] T000518_A9LugarNombre ;
      private String[] T000518_A40001LugarFoto_GXI ;
      private String[] T000518_A10LugarFoto ;
      private String[] T000519_A30LugarPaisNombre ;
      private String[] T000519_A40002LugarPaisBandera_GXI ;
      private bool[] T000519_n40002LugarPaisBandera_GXI ;
      private String[] T000519_A31LugarPaisBandera ;
      private String[] T000520_A33LugarCiudadNombre ;
      private short[] T000521_A34EspectaculoId ;
      private short[] T00057_A34EspectaculoId ;
      private String[] T00057_A35EspectaculoNombre ;
      private DateTime[] T00057_A36EspectaculoFecha ;
      private short[] T00057_A8LugarId ;
      private short[] T00057_A6TipoEspectaculoId ;
      private short[] T00057_A19EspectaculoPaisId ;
      private short[] T00057_A29LugarPaisId ;
      private short[] T00057_A22EspectaculoCiudadId ;
      private short[] T00057_A32LugarCiudadId ;
      private short[] T000522_A34EspectaculoId ;
      private short[] T000523_A34EspectaculoId ;
      private short[] T00056_A34EspectaculoId ;
      private String[] T00056_A35EspectaculoNombre ;
      private DateTime[] T00056_A36EspectaculoFecha ;
      private short[] T00056_A8LugarId ;
      private short[] T00056_A6TipoEspectaculoId ;
      private short[] T00056_A19EspectaculoPaisId ;
      private short[] T00056_A29LugarPaisId ;
      private short[] T00056_A22EspectaculoCiudadId ;
      private short[] T00056_A32LugarCiudadId ;
      private String[] T000527_A7TipoEspectaculoNombre ;
      private String[] T000528_A20EspectaculoPaisNombre ;
      private String[] T000528_A40000EspectaculoPaisBandera_GXI ;
      private bool[] T000528_n40000EspectaculoPaisBandera_GXI ;
      private String[] T000528_A21EspectaculoPaisBandera ;
      private String[] T000529_A23EspectaculoCiudadNombre ;
      private String[] T000530_A9LugarNombre ;
      private String[] T000530_A40001LugarFoto_GXI ;
      private String[] T000530_A10LugarFoto ;
      private String[] T000531_A30LugarPaisNombre ;
      private String[] T000531_A40002LugarPaisBandera_GXI ;
      private bool[] T000531_n40002LugarPaisBandera_GXI ;
      private String[] T000531_A31LugarPaisBandera ;
      private String[] T000532_A33LugarCiudadNombre ;
      private short[] T000533_A37VentaId ;
      private short[] T000534_A34EspectaculoId ;
      private short[] T000534_A11LocalidadId ;
      private short[] T000535_A34EspectaculoId ;
      private short[] T000536_A34EspectaculoId ;
      private short[] T000536_A11LocalidadId ;
      private String[] T000536_A12LocalidadNombre ;
      private int[] T000536_A13LocalidadCapacidad ;
      private decimal[] T000536_A14LocalidadPrecio ;
      private int[] T000536_A15LocalidadesVendidas ;
      private int[] T000536_A16LocalidadesDisponibles ;
      private short[] T000537_A34EspectaculoId ;
      private short[] T000537_A11LocalidadId ;
      private short[] T00055_A34EspectaculoId ;
      private short[] T00055_A11LocalidadId ;
      private String[] T00055_A12LocalidadNombre ;
      private int[] T00055_A13LocalidadCapacidad ;
      private decimal[] T00055_A14LocalidadPrecio ;
      private int[] T00055_A15LocalidadesVendidas ;
      private int[] T00055_A16LocalidadesDisponibles ;
      private short[] T00054_A34EspectaculoId ;
      private short[] T00054_A11LocalidadId ;
      private String[] T00054_A12LocalidadNombre ;
      private int[] T00054_A13LocalidadCapacidad ;
      private decimal[] T00054_A14LocalidadPrecio ;
      private int[] T00054_A15LocalidadesVendidas ;
      private int[] T00054_A16LocalidadesDisponibles ;
      private short[] T000541_A34EspectaculoId ;
      private short[] T000541_A11LocalidadId ;
      private short[] T000542_A34EspectaculoId ;
      private short[] T000542_A11LocalidadId ;
      private short[] T000542_A17SectorId ;
      private String[] T000542_A18SectorNombre ;
      private short[] T000543_A34EspectaculoId ;
      private short[] T000543_A11LocalidadId ;
      private short[] T000543_A17SectorId ;
      private short[] T00053_A34EspectaculoId ;
      private short[] T00053_A11LocalidadId ;
      private short[] T00053_A17SectorId ;
      private String[] T00053_A18SectorNombre ;
      private short[] T00052_A34EspectaculoId ;
      private short[] T00052_A11LocalidadId ;
      private short[] T00052_A17SectorId ;
      private String[] T00052_A18SectorNombre ;
      private short[] T000547_A34EspectaculoId ;
      private short[] T000547_A11LocalidadId ;
      private short[] T000547_A17SectorId ;
      private GXWebForm Form ;
      private SdtTransactionContext AV9TrnContext ;
      private SdtTransactionContext_Attribute AV18TrnContextAtt ;
   }

   public class espectaculo__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
         ,new ForEachCursor(def[29])
         ,new ForEachCursor(def[30])
         ,new ForEachCursor(def[31])
         ,new ForEachCursor(def[32])
         ,new ForEachCursor(def[33])
         ,new ForEachCursor(def[34])
         ,new ForEachCursor(def[35])
         ,new UpdateCursor(def[36])
         ,new UpdateCursor(def[37])
         ,new UpdateCursor(def[38])
         ,new ForEachCursor(def[39])
         ,new ForEachCursor(def[40])
         ,new ForEachCursor(def[41])
         ,new UpdateCursor(def[42])
         ,new UpdateCursor(def[43])
         ,new UpdateCursor(def[44])
         ,new ForEachCursor(def[45])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000515 ;
          prmT000515 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000516 ;
          prmT000516 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000517 ;
          prmT000517 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000518 ;
          prmT000518 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000519 ;
          prmT000519 = new Object[] {
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000520 ;
          prmT000520 = new Object[] {
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000521 ;
          prmT000521 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000522 ;
          prmT000522 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000523 ;
          prmT000523 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000524 ;
          prmT000524 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@EspectaculoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000525 ;
          prmT000525 = new Object[] {
          new Object[] {"@EspectaculoNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@EspectaculoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000526 ;
          prmT000526 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000533 ;
          prmT000533 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000534 ;
          prmT000534 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000535 ;
          prmT000535 = new Object[] {
          } ;
          Object[] prmT000536 ;
          prmT000536 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000537 ;
          prmT000537 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000538 ;
          prmT000538 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@LocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadesDisponibles",SqlDbType.Int,5,0}
          } ;
          Object[] prmT000539 ;
          prmT000539 = new Object[] {
          new Object[] {"@LocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@LocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@LocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@LocalidadesDisponibles",SqlDbType.Int,5,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000540 ;
          prmT000540 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000541 ;
          prmT000541 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000542 ;
          prmT000542 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000543 ;
          prmT000543 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000544 ;
          prmT000544 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorNombre",SqlDbType.NChar,100,0}
          } ;
          Object[] prmT000545 ;
          prmT000545 = new Object[] {
          new Object[] {"@SectorNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000546 ;
          prmT000546 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SectorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000547 ;
          prmT000547 = new Object[] {
          new Object[] {"@EspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LocalidadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000527 ;
          prmT000527 = new Object[] {
          new Object[] {"@TipoEspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000528 ;
          prmT000528 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000529 ;
          prmT000529 = new Object[] {
          new Object[] {"@EspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EspectaculoCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000530 ;
          prmT000530 = new Object[] {
          new Object[] {"@LugarId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000531 ;
          prmT000531 = new Object[] {
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000532 ;
          prmT000532 = new Object[] {
          new Object[] {"@LugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@LugarCiudadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [EspectaculoId], [LocalidadId], [SectorId], [SectorNombre] FROM [EspectaculoLocalidadSector] WITH (UPDLOCK) WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00053", "SELECT [EspectaculoId], [LocalidadId], [SectorId], [SectorNombre] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00054", "SELECT [EspectaculoId], [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles] FROM [EspectaculoLocalidad] WITH (UPDLOCK) WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00055", "SELECT [EspectaculoId], [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00056", "SELECT [EspectaculoId], [EspectaculoNombre], [EspectaculoFecha], [LugarId], [TipoEspectaculoId], [EspectaculoPaisId] AS EspectaculoPaisId, [LugarPaisId] AS LugarPaisId, [EspectaculoCiudadId] AS EspectaculoCiudadId, [LugarCiudadId] AS LugarCiudadId FROM [Espectaculo] WITH (UPDLOCK) WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00057", "SELECT [EspectaculoId], [EspectaculoNombre], [EspectaculoFecha], [LugarId], [TipoEspectaculoId], [EspectaculoPaisId] AS EspectaculoPaisId, [LugarPaisId] AS LugarPaisId, [EspectaculoCiudadId] AS EspectaculoCiudadId, [LugarCiudadId] AS LugarCiudadId FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00058", "SELECT [LugarNombre], [LugarFoto_GXI], [LugarFoto] FROM [Lugar] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T00059", "SELECT [TipoEspectaculoNombre] FROM [TipoEspectaculo] WHERE [TipoEspectaculoId] = @TipoEspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00059,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000510", "SELECT [PaisNombre] AS EspectaculoPaisNombre, [PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, [PaisBandera] AS EspectaculoPaisBandera FROM [Pais] WHERE [PaisId] = @EspectaculoPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000511", "SELECT [PaisNombre] AS LugarPaisNombre, [PaisBandera_GXI] AS LugarPaisBandera_GXI, [PaisBandera] AS LugarPaisBandera FROM [Pais] WHERE [PaisId] = @LugarPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000511,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000512", "SELECT [CiudadNombre] AS EspectaculoCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @EspectaculoPaisId AND [CiudadId] = @EspectaculoCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000512,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000513", "SELECT [CiudadNombre] AS LugarCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @LugarPaisId AND [CiudadId] = @LugarCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000514", "SELECT TM1.[EspectaculoId], TM1.[EspectaculoNombre], TM1.[EspectaculoFecha], T2.[TipoEspectaculoNombre], T3.[PaisNombre] AS EspectaculoPaisNombre, T3.[PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, T4.[CiudadNombre] AS EspectaculoCiudadNombre, T5.[LugarNombre], T5.[LugarFoto_GXI], T6.[PaisNombre] AS LugarPaisNombre, T6.[PaisBandera_GXI] AS LugarPaisBandera_GXI, T7.[CiudadNombre] AS LugarCiudadNombre, TM1.[LugarId], TM1.[TipoEspectaculoId], TM1.[EspectaculoPaisId] AS EspectaculoPaisId, TM1.[LugarPaisId] AS LugarPaisId, TM1.[EspectaculoCiudadId] AS EspectaculoCiudadId, TM1.[LugarCiudadId] AS LugarCiudadId, T3.[PaisBandera] AS EspectaculoPaisBandera, T5.[LugarFoto], T6.[PaisBandera] AS LugarPaisBandera FROM (((((([Espectaculo] TM1 INNER JOIN [TipoEspectaculo] T2 ON T2.[TipoEspectaculoId] = TM1.[TipoEspectaculoId]) INNER JOIN [Pais] T3 ON T3.[PaisId] = TM1.[EspectaculoPaisId]) INNER JOIN [PaisCiudad] T4 ON T4.[PaisId] = TM1.[EspectaculoPaisId] AND T4.[CiudadId] = TM1.[EspectaculoCiudadId]) INNER JOIN [Lugar] T5 ON T5.[LugarId] = TM1.[LugarId]) INNER JOIN [Pais] T6 ON T6.[PaisId] = TM1.[LugarPaisId]) INNER JOIN [PaisCiudad] T7 ON T7.[PaisId] = TM1.[LugarPaisId] AND T7.[CiudadId] = TM1.[LugarCiudadId]) WHERE TM1.[EspectaculoId] = @EspectaculoId ORDER BY TM1.[EspectaculoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000515", "SELECT [TipoEspectaculoNombre] FROM [TipoEspectaculo] WHERE [TipoEspectaculoId] = @TipoEspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000515,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000516", "SELECT [PaisNombre] AS EspectaculoPaisNombre, [PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, [PaisBandera] AS EspectaculoPaisBandera FROM [Pais] WHERE [PaisId] = @EspectaculoPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000516,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000517", "SELECT [CiudadNombre] AS EspectaculoCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @EspectaculoPaisId AND [CiudadId] = @EspectaculoCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000517,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000518", "SELECT [LugarNombre], [LugarFoto_GXI], [LugarFoto] FROM [Lugar] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000518,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000519", "SELECT [PaisNombre] AS LugarPaisNombre, [PaisBandera_GXI] AS LugarPaisBandera_GXI, [PaisBandera] AS LugarPaisBandera FROM [Pais] WHERE [PaisId] = @LugarPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000519,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000520", "SELECT [CiudadNombre] AS LugarCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @LugarPaisId AND [CiudadId] = @LugarCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000520,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000521", "SELECT [EspectaculoId] FROM [Espectaculo] WHERE [EspectaculoId] = @EspectaculoId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000521,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000522", "SELECT TOP 1 [EspectaculoId] FROM [Espectaculo] WHERE ( [EspectaculoId] > @EspectaculoId) ORDER BY [EspectaculoId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000522,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000523", "SELECT TOP 1 [EspectaculoId] FROM [Espectaculo] WHERE ( [EspectaculoId] < @EspectaculoId) ORDER BY [EspectaculoId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000523,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000524", "INSERT INTO [Espectaculo]([EspectaculoId], [EspectaculoNombre], [EspectaculoFecha], [LugarId], [TipoEspectaculoId], [EspectaculoPaisId], [LugarPaisId], [EspectaculoCiudadId], [LugarCiudadId]) VALUES(@EspectaculoId, @EspectaculoNombre, @EspectaculoFecha, @LugarId, @TipoEspectaculoId, @EspectaculoPaisId, @LugarPaisId, @EspectaculoCiudadId, @LugarCiudadId)", GxErrorMask.GX_NOMASK,prmT000524)
             ,new CursorDef("T000525", "UPDATE [Espectaculo] SET [EspectaculoNombre]=@EspectaculoNombre, [EspectaculoFecha]=@EspectaculoFecha, [LugarId]=@LugarId, [TipoEspectaculoId]=@TipoEspectaculoId, [EspectaculoPaisId]=@EspectaculoPaisId, [LugarPaisId]=@LugarPaisId, [EspectaculoCiudadId]=@EspectaculoCiudadId, [LugarCiudadId]=@LugarCiudadId  WHERE [EspectaculoId] = @EspectaculoId", GxErrorMask.GX_NOMASK,prmT000525)
             ,new CursorDef("T000526", "DELETE FROM [Espectaculo]  WHERE [EspectaculoId] = @EspectaculoId", GxErrorMask.GX_NOMASK,prmT000526)
             ,new CursorDef("T000527", "SELECT [TipoEspectaculoNombre] FROM [TipoEspectaculo] WHERE [TipoEspectaculoId] = @TipoEspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000527,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000528", "SELECT [PaisNombre] AS EspectaculoPaisNombre, [PaisBandera_GXI] AS EspectaculoPaisBandera_GXI, [PaisBandera] AS EspectaculoPaisBandera FROM [Pais] WHERE [PaisId] = @EspectaculoPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000528,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000529", "SELECT [CiudadNombre] AS EspectaculoCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @EspectaculoPaisId AND [CiudadId] = @EspectaculoCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000529,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000530", "SELECT [LugarNombre], [LugarFoto_GXI], [LugarFoto] FROM [Lugar] WHERE [LugarId] = @LugarId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000530,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000531", "SELECT [PaisNombre] AS LugarPaisNombre, [PaisBandera_GXI] AS LugarPaisBandera_GXI, [PaisBandera] AS LugarPaisBandera FROM [Pais] WHERE [PaisId] = @LugarPaisId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000531,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000532", "SELECT [CiudadNombre] AS LugarCiudadNombre FROM [PaisCiudad] WHERE [PaisId] = @LugarPaisId AND [CiudadId] = @LugarCiudadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000532,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000533", "SELECT TOP 1 [VentaId] FROM [Venta] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000533,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000534", "SELECT TOP 1 [EspectaculoId], [LocalidadId] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000534,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("T000535", "SELECT [EspectaculoId] FROM [Espectaculo] ORDER BY [EspectaculoId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000535,100, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000536", "SELECT [EspectaculoId], [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId and [LocalidadId] = @LocalidadId ORDER BY [EspectaculoId], [LocalidadId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000536,6, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000537", "SELECT [EspectaculoId], [LocalidadId] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000537,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000538", "INSERT INTO [EspectaculoLocalidad]([EspectaculoId], [LocalidadId], [LocalidadNombre], [LocalidadCapacidad], [LocalidadPrecio], [LocalidadesVendidas], [LocalidadesDisponibles]) VALUES(@EspectaculoId, @LocalidadId, @LocalidadNombre, @LocalidadCapacidad, @LocalidadPrecio, @LocalidadesVendidas, @LocalidadesDisponibles)", GxErrorMask.GX_NOMASK,prmT000538)
             ,new CursorDef("T000539", "UPDATE [EspectaculoLocalidad] SET [LocalidadNombre]=@LocalidadNombre, [LocalidadCapacidad]=@LocalidadCapacidad, [LocalidadPrecio]=@LocalidadPrecio, [LocalidadesVendidas]=@LocalidadesVendidas, [LocalidadesDisponibles]=@LocalidadesDisponibles  WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId", GxErrorMask.GX_NOMASK,prmT000539)
             ,new CursorDef("T000540", "DELETE FROM [EspectaculoLocalidad]  WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId", GxErrorMask.GX_NOMASK,prmT000540)
             ,new CursorDef("T000541", "SELECT [EspectaculoId], [LocalidadId] FROM [EspectaculoLocalidad] WHERE [EspectaculoId] = @EspectaculoId ORDER BY [EspectaculoId], [LocalidadId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000541,6, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000542", "SELECT [EspectaculoId], [LocalidadId], [SectorId], [SectorNombre] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId and [LocalidadId] = @LocalidadId and [SectorId] = @SectorId ORDER BY [EspectaculoId], [LocalidadId], [SectorId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000542,11, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000543", "SELECT [EspectaculoId], [LocalidadId], [SectorId] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000543,1, GxCacheFrequency.OFF ,true,false )
             ,new CursorDef("T000544", "INSERT INTO [EspectaculoLocalidadSector]([EspectaculoId], [LocalidadId], [SectorId], [SectorNombre]) VALUES(@EspectaculoId, @LocalidadId, @SectorId, @SectorNombre)", GxErrorMask.GX_NOMASK,prmT000544)
             ,new CursorDef("T000545", "UPDATE [EspectaculoLocalidadSector] SET [SectorNombre]=@SectorNombre  WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId", GxErrorMask.GX_NOMASK,prmT000545)
             ,new CursorDef("T000546", "DELETE FROM [EspectaculoLocalidadSector]  WHERE [EspectaculoId] = @EspectaculoId AND [LocalidadId] = @LocalidadId AND [SectorId] = @SectorId", GxErrorMask.GX_NOMASK,prmT000546)
             ,new CursorDef("T000547", "SELECT [EspectaculoId], [LocalidadId], [SectorId] FROM [EspectaculoLocalidadSector] WHERE [EspectaculoId] = @EspectaculoId and [LocalidadId] = @LocalidadId ORDER BY [EspectaculoId], [LocalidadId], [SectorId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000547,11, GxCacheFrequency.OFF ,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 7 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 8 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 9 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 11 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                ((DateTime[]) buf[2])[0] = rslt.getGXDate(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaUri(6) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(6);
                ((String[]) buf[7])[0] = rslt.getString(7, 100) ;
                ((String[]) buf[8])[0] = rslt.getString(8, 100) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaUri(9) ;
                ((String[]) buf[10])[0] = rslt.getString(10, 100) ;
                ((String[]) buf[11])[0] = rslt.getMultimediaUri(11) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(11);
                ((String[]) buf[13])[0] = rslt.getString(12, 100) ;
                ((short[]) buf[14])[0] = rslt.getShort(13) ;
                ((short[]) buf[15])[0] = rslt.getShort(14) ;
                ((short[]) buf[16])[0] = rslt.getShort(15) ;
                ((short[]) buf[17])[0] = rslt.getShort(16) ;
                ((short[]) buf[18])[0] = rslt.getShort(17) ;
                ((short[]) buf[19])[0] = rslt.getShort(18) ;
                ((String[]) buf[20])[0] = rslt.getMultimediaFile(19, rslt.getVarchar(6)) ;
                ((String[]) buf[21])[0] = rslt.getMultimediaFile(20, rslt.getVarchar(9)) ;
                ((String[]) buf[22])[0] = rslt.getMultimediaFile(21, rslt.getVarchar(11)) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 15 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 16 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 17 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 19 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 28 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
             case 29 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                ((String[]) buf[1])[0] = rslt.getMultimediaUri(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(3, rslt.getVarchar(2)) ;
                return;
       }
       getresults30( cursor, rslt, buf) ;
    }

    public void getresults30( int cursor ,
                              IFieldGetter rslt ,
                              Object[] buf )
    {
       switch ( cursor )
       {
             case 30 :
                ((String[]) buf[0])[0] = rslt.getString(1, 100) ;
                return;
             case 31 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 32 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 33 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 34 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 100) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                return;
             case 35 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 39 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 40 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 100) ;
                return;
             case 41 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 45 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
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
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                return;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                return;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 29 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
       setparameters30( cursor, stmt, parms) ;
    }

    public void setparameters30( int cursor ,
                                 IFieldSetter stmt ,
                                 Object[] parms )
    {
       switch ( cursor )
       {
             case 30 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 31 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 32 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 34 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 35 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 36 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (int)parms[5]);
                stmt.SetParameter(7, (int)parms[6]);
                return;
             case 37 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (decimal)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 38 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 39 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 40 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 41 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 42 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                return;
             case 43 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 44 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 45 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
       }
    }

 }

}
