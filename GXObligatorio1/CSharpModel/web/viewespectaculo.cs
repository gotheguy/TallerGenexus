/*
               File: ViewEspectaculo
        Description: View Espectaculo
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:51:4.70
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
   public class viewespectaculo : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public viewespectaculo( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public viewespectaculo( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_EspectaculoId ,
                           String aP1_TabCode )
      {
         this.AV12EspectaculoId = aP0_EspectaculoId;
         this.AV6TabCode = aP1_TabCode;
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

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
               AV12EspectaculoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV12EspectaculoId", StringUtil.LTrimStr( (decimal)(AV12EspectaculoId), 4, 0));
               AssignAttri("", false, "gxhash_vESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EspectaculoId), "ZZZ9"), context));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV6TabCode = GetNextPar( );
                  AssignAttri("", false, "AV6TabCode", AV6TabCode);
                  AssignAttri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
               }
            }
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA1R2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1R2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?20202162151473", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("viewespectaculo.aspx") + "?" + UrlEncode("" +AV12EspectaculoId) + "," + UrlEncode(StringUtil.RTrim(AV6TabCode))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "gxhash_vESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EspectaculoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         forbiddenHiddens = new GXProperties();
         forbiddenHiddens.Add("hshsalt", "hsh"+"ViewEspectaculo");
         forbiddenHiddens.Add("EspectaculoNombre", StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens.ToString(), GXKey));
         GXUtil.WriteLog("viewespectaculo:[ SendSecurityCheck value for]"+forbiddenHiddens.ToJSonString());
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_boolean_hidden_field( context, "vLOADALLTABS", AV11LoadAllTabs);
         GxWebStd.gx_hidden_field( context, "vSELECTEDTABCODE", StringUtil.RTrim( AV7SelectedTabCode));
         GxWebStd.gx_hidden_field( context, "vESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12EspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EspectaculoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "vTABCODE", StringUtil.RTrim( AV6TabCode));
         GxWebStd.gx_hidden_field( context, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
         GxWebStd.gx_hidden_field( context, "TAB_Activepagecontrolname", StringUtil.RTrim( Tab_Activepagecontrolname));
         GxWebStd.gx_hidden_field( context, "TAB_Pagecount", StringUtil.LTrim( StringUtil.NToC( (decimal)(Tab_Pagecount), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TAB_Class", StringUtil.RTrim( Tab_Class));
         GxWebStd.gx_hidden_field( context, "TAB_Historymanagement", StringUtil.BoolToStr( Tab_Historymanagement));
         GxWebStd.gx_hidden_field( context, "TAB_Activepagecontrolname", StringUtil.RTrim( Tab_Activepagecontrolname));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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
         if ( ! ( WebComp_Generalwc == null ) )
         {
            WebComp_Generalwc.componentjscripts();
         }
         if ( ! ( WebComp_Localidadwc == null ) )
         {
            WebComp_Localidadwc.componentjscripts();
         }
         if ( ! ( WebComp_Ventawc == null ) )
         {
            WebComp_Ventawc.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE1R2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1R2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("viewespectaculo.aspx") + "?" + UrlEncode("" +AV12EspectaculoId) + "," + UrlEncode(StringUtil.RTrim(AV6TabCode)) ;
      }

      public override String GetPgmname( )
      {
         return "ViewEspectaculo" ;
      }

      public override String GetPgmdesc( )
      {
         return "View Espectaculo" ;
      }

      protected void WB1R0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divMaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabletop_Internalname, 1, 0, "px", 0, "px", "TableTopSearch", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 col-sm-offset-2", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblViewtitle_Internalname, "Espectaculo Information", "", "", lblViewtitle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "SubTitle", 0, "", 1, 1, 0, "HLP_ViewEspectaculo.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 ViewActionsBackCell", "Right", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblViewall_Internalname, "Espectaculoes", lblViewall_Link, "", lblViewall_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "BtnTextBlockBack", 0, "", lblViewall_Visible, 1, 0, "HLP_ViewEspectaculo.htm");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 col-sm-offset-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabtable_1_Internalname, 1, 0, "px", 0, "px", "ViewTable", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtEspectaculoNombre_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtEspectaculoNombre_Internalname, "Nombre", "col-sm-3 ReadonlyAttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtEspectaculoNombre_Internalname, StringUtil.RTrim( A35EspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtEspectaculoNombre_Jsonclick, 0, "ReadonlyAttribute", "", "", "", "", 1, edtEspectaculoNombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "Nombre", "left", true, "", "HLP_ViewEspectaculo.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-10 col-xs-offset-1", "left", "top", "", "", "div");
            /* User Defined Control */
            ucTab.SetProperty("PageCount", Tab_Pagecount);
            ucTab.SetProperty("Class", Tab_Class);
            ucTab.SetProperty("HistoryManagement", Tab_Historymanagement);
            ucTab.Render(context, "tab", Tab_Internalname, "TABContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title1"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblGeneral_title_Internalname, "General", "", "", lblGeneral_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEspectaculo.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "General") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel1"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablegeneral_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0030"+"", StringUtil.RTrim( WebComp_Generalwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0030"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
                  }
                  WebComp_Generalwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldGeneralwc), StringUtil.Lower( WebComp_Generalwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title2"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLocalidad_title_Internalname, "Localidad", "", "", lblLocalidad_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEspectaculo.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Localidad") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel2"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablelocalidad_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0038"+"", StringUtil.RTrim( WebComp_Localidadwc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0038"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Localidadwc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldLocalidadwc), StringUtil.Lower( WebComp_Localidadwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
                  }
                  WebComp_Localidadwc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldLocalidadwc), StringUtil.Lower( WebComp_Localidadwc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"title3"+"\" style=\"display:none;\">") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblVenta_title_Internalname, "Venta", "", "", lblVenta_title_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "TextBlock", 0, "", 1, 1, 0, "HLP_ViewEspectaculo.htm");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", "", "display:none;", "div");
            context.WriteHtmlText( "Venta") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"TABContainer"+"panel3"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableventa_Internalname, 1, 0, "px", 0, "px", "TabsFormContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, "W0046"+"", StringUtil.RTrim( WebComp_Ventawc_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+"gxHTMLWrpW0046"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Ventawc_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldVentawc), StringUtil.Lower( WebComp_Ventawc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
                  }
                  WebComp_Ventawc.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldVentawc), StringUtil.Lower( WebComp_Ventawc_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         wbLoad = true;
      }

      protected void START1R2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "View Espectaculo", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP1R0( ) ;
      }

      protected void WS1R2( )
      {
         START1R2( ) ;
         EVT1R2( ) ;
      }

      protected void EVT1R2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Start */
                              E111R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: Load */
                              E121R2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4);
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4));
                        nCmpId = (short)(NumberUtil.Val( sEvtType, "."));
                        if ( nCmpId == 30 )
                        {
                           OldGeneralwc = cgiGet( "W0030");
                           if ( ( StringUtil.Len( OldGeneralwc) == 0 ) || ( StringUtil.StrCmp(OldGeneralwc, WebComp_Generalwc_Component) != 0 ) )
                           {
                              WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", OldGeneralwc, new Object[] {context} );
                              WebComp_Generalwc.ComponentInit();
                              WebComp_Generalwc.Name = "OldGeneralwc";
                              WebComp_Generalwc_Component = OldGeneralwc;
                           }
                           if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
                           {
                              WebComp_Generalwc.componentprocess("W0030", "", sEvt);
                           }
                           WebComp_Generalwc_Component = OldGeneralwc;
                        }
                        else if ( nCmpId == 38 )
                        {
                           OldLocalidadwc = cgiGet( "W0038");
                           if ( ( StringUtil.Len( OldLocalidadwc) == 0 ) || ( StringUtil.StrCmp(OldLocalidadwc, WebComp_Localidadwc_Component) != 0 ) )
                           {
                              WebComp_Localidadwc = getWebComponent(GetType(), "GeneXus.Programs", OldLocalidadwc, new Object[] {context} );
                              WebComp_Localidadwc.ComponentInit();
                              WebComp_Localidadwc.Name = "OldLocalidadwc";
                              WebComp_Localidadwc_Component = OldLocalidadwc;
                           }
                           if ( StringUtil.Len( WebComp_Localidadwc_Component) != 0 )
                           {
                              WebComp_Localidadwc.componentprocess("W0038", "", sEvt);
                           }
                           WebComp_Localidadwc_Component = OldLocalidadwc;
                        }
                        else if ( nCmpId == 46 )
                        {
                           OldVentawc = cgiGet( "W0046");
                           if ( ( StringUtil.Len( OldVentawc) == 0 ) || ( StringUtil.StrCmp(OldVentawc, WebComp_Ventawc_Component) != 0 ) )
                           {
                              WebComp_Ventawc = getWebComponent(GetType(), "GeneXus.Programs", OldVentawc, new Object[] {context} );
                              WebComp_Ventawc.ComponentInit();
                              WebComp_Ventawc.Name = "OldVentawc";
                              WebComp_Ventawc_Component = OldVentawc;
                           }
                           if ( StringUtil.Len( WebComp_Ventawc_Component) != 0 )
                           {
                              WebComp_Ventawc.componentprocess("W0046", "", sEvt);
                           }
                           WebComp_Ventawc_Component = OldVentawc;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE1R2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA1R2( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void send_integrity_hashes( )
      {
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF1R2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV15Pgmname = "ViewEspectaculo";
         context.Gx_err = 0;
      }

      protected void RF1R2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
               {
                  WebComp_Generalwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Localidadwc_Component) != 0 )
               {
                  WebComp_Localidadwc.componentstart();
               }
            }
         }
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Ventawc_Component) != 0 )
               {
                  WebComp_Ventawc.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Using cursor H001R2 */
            pr_default.execute(0, new Object[] {AV12EspectaculoId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A34EspectaculoId = H001R2_A34EspectaculoId[0];
               A35EspectaculoNombre = H001R2_A35EspectaculoNombre[0];
               AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
               /* Execute user event: Load */
               E121R2 ();
               /* Exiting from a For First loop. */
               if (true) break;
            }
            pr_default.close(0);
            WB1R0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes1R2( )
      {
      }

      protected void STRUP1R0( )
      {
         /* Before Start, stand alone formulas. */
         AV15Pgmname = "ViewEspectaculo";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E111R2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            AV12EspectaculoId = (short)(context.localUtil.CToN( cgiGet( "vESPECTACULOID"), ".", ","));
            AV11LoadAllTabs = StringUtil.StrToBool( cgiGet( "vLOADALLTABS"));
            AV7SelectedTabCode = cgiGet( "vSELECTEDTABCODE");
            Tab_Activepagecontrolname = cgiGet( "TAB_Activepagecontrolname");
            Tab_Pagecount = (int)(context.localUtil.CToN( cgiGet( "TAB_Pagecount"), ".", ","));
            Tab_Class = cgiGet( "TAB_Class");
            Tab_Historymanagement = StringUtil.StrToBool( cgiGet( "TAB_Historymanagement"));
            /* Read variables values. */
            A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            forbiddenHiddens = new GXProperties();
            forbiddenHiddens.Add("hshsalt", "hsh"+"ViewEspectaculo");
            A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            forbiddenHiddens.Add("EspectaculoNombre", StringUtil.RTrim( context.localUtil.Format( A35EspectaculoNombre, "")));
            hsh = cgiGet( "hsh");
            if ( ! GXUtil.CheckEncryptedHash( forbiddenHiddens.ToString(), hsh, GXKey) )
            {
               GXUtil.WriteLog("viewespectaculo:[ SecurityCheckFailed value for]"+forbiddenHiddens.ToJSonString());
               GxWebError = 1;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.HttpContext.Response.StatusCode = 403;
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
               GXUtil.WriteLog("send_http_error_code " + 403.ToString());
               return  ;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E111R2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111R2( )
      {
         /* Start Routine */
         if ( ! new isauthorized(context).executeUdp(  AV15Pgmname) )
         {
            CallWebObject(formatLink("notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV16GXLvl6 = 0;
         /* Using cursor H001R3 */
         pr_default.execute(1, new Object[] {AV12EspectaculoId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A34EspectaculoId = H001R3_A34EspectaculoId[0];
            A35EspectaculoNombre = H001R3_A35EspectaculoNombre[0];
            AssignAttri("", false, "A35EspectaculoNombre", A35EspectaculoNombre);
            AV16GXLvl6 = 1;
            Form.Caption = A35EspectaculoNombre;
            AssignProp("", false, "FORM", "Caption", Form.Caption, true);
            lblViewall_Link = formatLink("wwespectaculo.aspx") ;
            AssignProp("", false, lblViewall_Internalname, "Link", lblViewall_Link, true);
            AV10Exists = true;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
         if ( AV16GXLvl6 == 0 )
         {
            Form.Caption = "Record not found";
            AssignProp("", false, "FORM", "Caption", Form.Caption, true);
            lblViewall_Visible = 0;
            AssignProp("", false, lblViewall_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(lblViewall_Visible), 5, 0), true);
            AV10Exists = false;
         }
         AV11LoadAllTabs = false;
         AssignAttri("", false, "AV11LoadAllTabs", AV11LoadAllTabs);
         if ( AV10Exists )
         {
            AV7SelectedTabCode = AV6TabCode;
            AssignAttri("", false, "AV7SelectedTabCode", AV7SelectedTabCode);
            Tab_Activepagecontrolname = AV7SelectedTabCode;
            ucTab.SendProperty(context, "", false, Tab_Internalname, "ActivePageControlName", Tab_Activepagecontrolname);
            /* Execute user subroutine: 'LOAD TAB' */
            S112 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
      }

      protected void S112( )
      {
         /* 'LOAD TAB' Routine */
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "") == 0 ) || ( StringUtil.StrCmp(AV7SelectedTabCode, "General") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Generalwc_Component), StringUtil.Lower( "EspectaculoGeneral")) != 0 )
            {
               WebComp_Generalwc = getWebComponent(GetType(), "GeneXus.Programs", "espectaculogeneral", new Object[] {context} );
               WebComp_Generalwc.ComponentInit();
               WebComp_Generalwc.Name = "EspectaculoGeneral";
               WebComp_Generalwc_Component = "EspectaculoGeneral";
            }
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.setjustcreated();
               WebComp_Generalwc.componentprepare(new Object[] {(String)"W0030",(String)"",(short)AV12EspectaculoId});
               WebComp_Generalwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0030"+"");
               WebComp_Generalwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Localidad") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Localidadwc_Component), StringUtil.Lower( "EspectaculoLocalidadWC")) != 0 )
            {
               WebComp_Localidadwc = getWebComponent(GetType(), "GeneXus.Programs", "espectaculolocalidadwc", new Object[] {context} );
               WebComp_Localidadwc.ComponentInit();
               WebComp_Localidadwc.Name = "EspectaculoLocalidadWC";
               WebComp_Localidadwc_Component = "EspectaculoLocalidadWC";
            }
            if ( StringUtil.Len( WebComp_Localidadwc_Component) != 0 )
            {
               WebComp_Localidadwc.setjustcreated();
               WebComp_Localidadwc.componentprepare(new Object[] {(String)"W0038",(String)"",(short)AV12EspectaculoId});
               WebComp_Localidadwc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0038"+"");
               WebComp_Localidadwc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         if ( AV11LoadAllTabs || ( StringUtil.StrCmp(AV7SelectedTabCode, "Venta") == 0 ) )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(StringUtil.Lower( WebComp_Ventawc_Component), StringUtil.Lower( "EspectaculoVentaWC")) != 0 )
            {
               WebComp_Ventawc = getWebComponent(GetType(), "GeneXus.Programs", "espectaculoventawc", new Object[] {context} );
               WebComp_Ventawc.ComponentInit();
               WebComp_Ventawc.Name = "EspectaculoVentaWC";
               WebComp_Ventawc_Component = "EspectaculoVentaWC";
            }
            if ( StringUtil.Len( WebComp_Ventawc_Component) != 0 )
            {
               WebComp_Ventawc.setjustcreated();
               WebComp_Ventawc.componentprepare(new Object[] {(String)"W0046",(String)"",(short)AV12EspectaculoId});
               WebComp_Ventawc.componentbind(new Object[] {(String)""});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0046"+"");
               WebComp_Ventawc.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E121R2( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12EspectaculoId = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV12EspectaculoId", StringUtil.LTrimStr( (decimal)(AV12EspectaculoId), 4, 0));
         AssignAttri("", false, "gxhash_vESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12EspectaculoId), "ZZZ9"), context));
         AV6TabCode = (String)getParm(obj,1);
         AssignAttri("", false, "AV6TabCode", AV6TabCode);
         AssignAttri("", false, "gxhash_vTABCODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV6TabCode, "")), context));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA1R2( ) ;
         WS1R2( ) ;
         WE1R2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         if ( ! ( WebComp_Generalwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Generalwc_Component) != 0 )
            {
               WebComp_Generalwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Localidadwc == null ) )
         {
            if ( StringUtil.Len( WebComp_Localidadwc_Component) != 0 )
            {
               WebComp_Localidadwc.componentthemes();
            }
         }
         if ( ! ( WebComp_Ventawc == null ) )
         {
            if ( StringUtil.Len( WebComp_Ventawc_Component) != 0 )
            {
               WebComp_Ventawc.componentthemes();
            }
         }
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202162151493", true, true);
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
         context.AddJavascriptSource("viewespectaculo.js", "?20202162151493", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         context.AddJavascriptSource("Tab/TabRender.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblViewtitle_Internalname = "VIEWTITLE";
         lblViewall_Internalname = "VIEWALL";
         divTabletop_Internalname = "TABLETOP";
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE";
         divTabtable_1_Internalname = "TABTABLE_1";
         lblGeneral_title_Internalname = "GENERAL_TITLE";
         divTablegeneral_Internalname = "TABLEGENERAL";
         lblLocalidad_title_Internalname = "LOCALIDAD_TITLE";
         divTablelocalidad_Internalname = "TABLELOCALIDAD";
         lblVenta_title_Internalname = "VENTA_TITLE";
         divTableventa_Internalname = "TABLEVENTA";
         Tab_Internalname = "TAB";
         divMaintable_Internalname = "MAINTABLE";
         Form.Internalname = "FORM";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("Carmine");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoNombre_Enabled = 0;
         lblViewall_Link = "";
         lblViewall_Visible = 1;
         Tab_Historymanagement = Convert.ToBoolean( -1);
         Tab_Class = "WWTab";
         Tab_Pagecount = 3;
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "View Espectaculo";
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12EspectaculoId',fld:'vESPECTACULOID',pic:'ZZZ9',hsh:true},{av:'AV6TabCode',fld:'vTABCODE',pic:'',hsh:true},{av:'A35EspectaculoNombre',fld:'ESPECTACULONOMBRE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         wcpOAV6TabCode = "";
         Tab_Activepagecontrolname = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXKey = "";
         forbiddenHiddens = new GXProperties();
         A35EspectaculoNombre = "";
         AV7SelectedTabCode = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblViewtitle_Jsonclick = "";
         lblViewall_Jsonclick = "";
         ucTab = new GXUserControl();
         lblGeneral_title_Jsonclick = "";
         WebComp_Generalwc_Component = "";
         OldGeneralwc = "";
         lblLocalidad_title_Jsonclick = "";
         WebComp_Localidadwc_Component = "";
         OldLocalidadwc = "";
         lblVenta_title_Jsonclick = "";
         WebComp_Ventawc_Component = "";
         OldVentawc = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV15Pgmname = "";
         scmdbuf = "";
         H001R2_A34EspectaculoId = new short[1] ;
         H001R2_A35EspectaculoNombre = new String[] {""} ;
         hsh = "";
         H001R3_A34EspectaculoId = new short[1] ;
         H001R3_A35EspectaculoNombre = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.viewespectaculo__default(),
            new Object[][] {
                new Object[] {
               H001R2_A34EspectaculoId, H001R2_A35EspectaculoNombre
               }
               , new Object[] {
               H001R3_A34EspectaculoId, H001R3_A35EspectaculoNombre
               }
            }
         );
         WebComp_Generalwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Localidadwc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Ventawc = new GeneXus.Http.GXNullWebComponent();
         AV15Pgmname = "ViewEspectaculo";
         /* GeneXus formulas. */
         AV15Pgmname = "ViewEspectaculo";
         context.Gx_err = 0;
      }

      private short AV12EspectaculoId ;
      private short wcpOAV12EspectaculoId ;
      private short nRcdExists_3 ;
      private short nIsMod_3 ;
      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A34EspectaculoId ;
      private short AV16GXLvl6 ;
      private short nGXWrapped ;
      private int Tab_Pagecount ;
      private int lblViewall_Visible ;
      private int edtEspectaculoNombre_Enabled ;
      private int idxLst ;
      private String AV6TabCode ;
      private String wcpOAV6TabCode ;
      private String Tab_Activepagecontrolname ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXKey ;
      private String A35EspectaculoNombre ;
      private String AV7SelectedTabCode ;
      private String Tab_Class ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMaintable_Internalname ;
      private String divTabletop_Internalname ;
      private String lblViewtitle_Internalname ;
      private String lblViewtitle_Jsonclick ;
      private String lblViewall_Internalname ;
      private String lblViewall_Link ;
      private String lblViewall_Jsonclick ;
      private String divTabtable_1_Internalname ;
      private String edtEspectaculoNombre_Internalname ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String Tab_Internalname ;
      private String lblGeneral_title_Internalname ;
      private String lblGeneral_title_Jsonclick ;
      private String divTablegeneral_Internalname ;
      private String WebComp_Generalwc_Component ;
      private String OldGeneralwc ;
      private String lblLocalidad_title_Internalname ;
      private String lblLocalidad_title_Jsonclick ;
      private String divTablelocalidad_Internalname ;
      private String WebComp_Localidadwc_Component ;
      private String OldLocalidadwc ;
      private String lblVenta_title_Internalname ;
      private String lblVenta_title_Jsonclick ;
      private String divTableventa_Internalname ;
      private String WebComp_Ventawc_Component ;
      private String OldVentawc ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String AV15Pgmname ;
      private String scmdbuf ;
      private String hsh ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV11LoadAllTabs ;
      private bool Tab_Historymanagement ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV10Exists ;
      private GXWebComponent WebComp_Generalwc ;
      private GXWebComponent WebComp_Localidadwc ;
      private GXWebComponent WebComp_Ventawc ;
      private GXProperties forbiddenHiddens ;
      private GXUserControl ucTab ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H001R2_A34EspectaculoId ;
      private String[] H001R2_A35EspectaculoNombre ;
      private short[] H001R3_A34EspectaculoId ;
      private String[] H001R3_A35EspectaculoNombre ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class viewespectaculo__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH001R2 ;
          prmH001R2 = new Object[] {
          new Object[] {"@AV12EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH001R3 ;
          prmH001R3 = new Object[] {
          new Object[] {"@AV12EspectaculoId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001R2", "SELECT [EspectaculoId], [EspectaculoNombre] FROM [Espectaculo] WHERE [EspectaculoId] = @AV12EspectaculoId ORDER BY [EspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R2,1, GxCacheFrequency.OFF ,true,true )
             ,new CursorDef("H001R3", "SELECT [EspectaculoId], [EspectaculoNombre] FROM [Espectaculo] WHERE [EspectaculoId] = @AV12EspectaculoId ORDER BY [EspectaculoId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001R3,1, GxCacheFrequency.OFF ,false,true )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 100) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

}