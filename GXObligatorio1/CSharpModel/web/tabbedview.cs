/*
               File: TabbedView
        Description: Tabbed View
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:49:10.15
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class tabbedview : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tabbedview( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
      }

      public tabbedview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( GXBaseCollection<SdtTabOptions_TabOptionsItem> aP0_Tabs ,
                           String aP1_TabCode )
      {
         this.AV18Tabs = aP0_Tabs;
         this.AV15TabCode = aP1_TabCode;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  ajax_req_read_hidden_sdt(GetNextPar( ), AV18Tabs);
                  AV15TabCode = GetNextPar( );
                  AssignAttri(sPrefix, false, "AV15TabCode", AV15TabCode);
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(GXBaseCollection<SdtTabOptions_TabOptionsItem>)AV18Tabs,(String)AV15TabCode});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA0I2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0;
               WS0I2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, false);
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Tabbed View") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 138086), false, true);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 138086), false, true);
         context.AddJavascriptSource("gxcfg.js", "?202021621491018", false, true);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"Form\" data-gx-class=\"Form\" novalidate action=\""+formatLink("tabbedview.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15TabCode))+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            AssignProp(sPrefix, false, "FORM", "Class", "Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV15TabCode", StringUtil.RTrim( wcpOAV15TabCode));
         GxWebStd.gx_hidden_field( context, sPrefix+"vFIRSTTAB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV5FirstTab), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vLASTTAB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11LastTab), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vTABS", AV18Tabs);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vTABS", AV18Tabs);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"vTABCODE", StringUtil.RTrim( AV15TabCode));
         GxWebStd.gx_hidden_field( context, sPrefix+"vINDEX", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8Index), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vSELECTEDTAB", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13SelectedTab), 4, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vTAB", AV14Tab);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vTAB", AV14Tab);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"vTABSMARKUP", StringUtil.RTrim( AV19TabsMarkup));
         GxWebStd.gx_hidden_field( context, sPrefix+"vTABTEMPLATE", StringUtil.RTrim( AV20TabTemplate));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vURLCHANGEDEVENT", AV23URLChangedEvent);
         GxWebStd.gx_hidden_field( context, sPrefix+"HISTORYMANAGER_Hash", StringUtil.RTrim( Historymanager_Hash));
         GxWebStd.gx_hidden_field( context, sPrefix+"HISTORYMANAGER_Hash", StringUtil.RTrim( Historymanager_Hash));
         GxWebStd.gx_hidden_field( context, sPrefix+"HISTORYMANAGER_Hash", StringUtil.RTrim( Historymanager_Hash));
      }

      protected void RenderHtmlCloseForm0I2( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("tabbedview.js", "?202021621491020", false, true);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
            if ( ! ( WebComp_Component == null ) )
            {
               WebComp_Component.componentjscripts();
            }
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
         }
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "TabbedView" ;
      }

      public override String GetPgmdesc( )
      {
         return "Tabbed View" ;
      }

      protected void WB0I0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tabbedview.aspx");
               context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
               context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
               context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
               context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_0I2( true) ;
         }
         else
         {
            wb_table1_2_0I2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0I2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* User Defined Control */
            ucHistorymanager.Render(context, "historymanager", Historymanager_Internalname, sPrefix+"HISTORYMANAGERContainer");
         }
         wbLoad = true;
      }

      protected void START0I2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
               Form.Meta.addItem("description", "Tabbed View", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP0I0( ) ;
            }
         }
      }

      protected void WS0I2( )
      {
         START0I2( ) ;
         EVT0I2( ) ;
      }

      protected void EVT0I2( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1);
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1));
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1);
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "HISTORYMANAGER.URLCHANGED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E110I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E120I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E130I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E140I2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP0I0( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
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
                        if ( nCmpId == 14 )
                        {
                           OldComponent = cgiGet( sPrefix+"W0014");
                           if ( ( StringUtil.Len( OldComponent) == 0 ) || ( StringUtil.StrCmp(OldComponent, WebComp_Component_Component) != 0 ) )
                           {
                              WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", OldComponent, new Object[] {context} );
                              WebComp_Component.ComponentInit();
                              WebComp_Component.Name = "OldComponent";
                              WebComp_Component_Component = OldComponent;
                           }
                           if ( StringUtil.Len( WebComp_Component_Component) != 0 )
                           {
                              WebComp_Component.componentprocess(sPrefix+"W0014", "", sEvt);
                           }
                           WebComp_Component_Component = OldComponent;
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE0I2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm0I2( ) ;
            }
         }
      }

      protected void PA0I2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
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
         RF0I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      protected void RF0I2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         /* Execute user event: Refresh */
         E130I2 ();
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Component_Component) != 0 )
               {
                  WebComp_Component.componentstart();
               }
            }
         }
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: Load */
            E140I2 ();
            WB0I0( ) ;
         }
      }

      protected void send_integrity_lvl_hashes0I2( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"vTABTEMPLATE", StringUtil.RTrim( AV20TabTemplate));
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
      }

      protected void STRUP0I0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E120I2 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            wcpOAV15TabCode = cgiGet( sPrefix+"wcpOAV15TabCode");
            Historymanager_Hash = cgiGet( sPrefix+"HISTORYMANAGER_Hash");
            Historymanager_Hash = cgiGet( sPrefix+"HISTORYMANAGER_Hash");
            /* Read variables values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E120I2 ();
         if (returnInSub) return;
      }

      protected void E120I2( )
      {
         /* Start Routine */
         /* Execute user subroutine: 'INIT' */
         S112 ();
         if (returnInSub) return;
      }

      protected void E110I2( )
      {
         /* Historymanager_Urlchanged Routine */
         /* Execute user subroutine: 'DRAW TABS' */
         S122 ();
         if (returnInSub) return;
         AV23URLChangedEvent = true;
         AssignAttri(sPrefix, false, "AV23URLChangedEvent", AV23URLChangedEvent);
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14Tab", AV14Tab);
      }

      protected void E130I2( )
      {
         /* Refresh Routine */
         if ( ! AV23URLChangedEvent )
         {
            /* Execute user subroutine: 'DRAW TABS' */
            S122 ();
            if (returnInSub) return;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV14Tab", AV14Tab);
      }

      protected void S112( )
      {
         /* 'INIT' Routine */
         AV20TabTemplate = "<li class=\"%1\">";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "<a id=\"%2Tab\" %3%7 class=\"%4\">";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "<span class=\"%5\">";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "<span class=\"TabBackground\">";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "<span class=\"TabText\">%6</span>";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "</span>";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "</span>";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "</a>";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
         AV20TabTemplate = AV20TabTemplate + "</li>";
         AssignAttri(sPrefix, false, "AV20TabTemplate", AV20TabTemplate);
         AssignAttri(sPrefix, false, sPrefix+"gxhash_vTABTEMPLATE", GetSecureSignedToken( sPrefix, StringUtil.RTrim( context.localUtil.Format( AV20TabTemplate, "")), context));
      }

      protected void S122( )
      {
         /* 'DRAW TABS' Routine */
         /* Execute user subroutine: 'FINDTABINDEX' */
         S132 ();
         if (returnInSub) return;
         /* Execute user subroutine: 'SCROLLTABS' */
         S142 ();
         if (returnInSub) return;
         AV9IsFirstTab = true;
         AV19TabsMarkup = "";
         AssignAttri(sPrefix, false, "AV19TabsMarkup", AV19TabsMarkup);
         AV8Index = AV5FirstTab;
         AssignAttri(sPrefix, false, "AV8Index", StringUtil.LTrimStr( (decimal)(AV8Index), 4, 0));
         while ( AV8Index <= AV11LastTab )
         {
            AV14Tab = ((SdtTabOptions_TabOptionsItem)AV18Tabs.Item(AV8Index));
            /* Execute user subroutine: 'LOADITEM' */
            S152 ();
            if (returnInSub) return;
            AV9IsFirstTab = false;
            AV8Index = (short)(AV8Index+1);
            AssignAttri(sPrefix, false, "AV8Index", StringUtil.LTrimStr( (decimal)(AV8Index), 4, 0));
         }
         lblTabs_Caption = StringUtil.Format( "<ul class=\"Tabs\">%1</ul>", AV19TabsMarkup, "", "", "", "", "", "", "", "");
         AssignProp(sPrefix, false, lblTabs_Internalname, "Caption", lblTabs_Caption, true);
      }

      protected void S132( )
      {
         /* 'FINDTABINDEX' Routine */
         AV6Found = false;
         AV8Index = 1;
         AssignAttri(sPrefix, false, "AV8Index", StringUtil.LTrimStr( (decimal)(AV8Index), 4, 0));
         while ( AV8Index <= AV18Tabs.Count )
         {
            if ( ( ( StringUtil.StrCmp(Historymanager_Hash, "") == 0 ) && ( ( StringUtil.StrCmp(((SdtTabOptions_TabOptionsItem)AV18Tabs.Item(AV8Index)).gxTpr_Code, AV15TabCode) == 0 ) ) ) || ( ( StringUtil.StrCmp(((SdtTabOptions_TabOptionsItem)AV18Tabs.Item(AV8Index)).gxTpr_Code, Historymanager_Hash) == 0 ) ) )
            {
               AV13SelectedTab = AV8Index;
               AssignAttri(sPrefix, false, "AV13SelectedTab", StringUtil.LTrimStr( (decimal)(AV13SelectedTab), 4, 0));
               AV6Found = true;
               if (true) break;
            }
            AV8Index = (short)(AV8Index+1);
            AssignAttri(sPrefix, false, "AV8Index", StringUtil.LTrimStr( (decimal)(AV8Index), 4, 0));
         }
         if ( ! AV6Found && ( AV18Tabs.Count > 0 ) )
         {
            AV13SelectedTab = 1;
            AssignAttri(sPrefix, false, "AV13SelectedTab", StringUtil.LTrimStr( (decimal)(AV13SelectedTab), 4, 0));
         }
      }

      protected void S142( )
      {
         /* 'SCROLLTABS' Routine */
         AV5FirstTab = 1;
         AssignAttri(sPrefix, false, "AV5FirstTab", StringUtil.LTrimStr( (decimal)(AV5FirstTab), 4, 0));
         AV11LastTab = (short)(AV18Tabs.Count);
         AssignAttri(sPrefix, false, "AV11LastTab", StringUtil.LTrimStr( (decimal)(AV11LastTab), 4, 0));
         imgTabprevious_Visible = 0;
         AssignProp(sPrefix, false, imgTabprevious_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgTabprevious_Visible), 5, 0), true);
         imgTabnext_Visible = 0;
         AssignProp(sPrefix, false, imgTabnext_Internalname, "Visible", StringUtil.LTrimStr( (decimal)(imgTabnext_Visible), 5, 0), true);
      }

      protected void S152( )
      {
         /* 'LOADITEM' Routine */
         AV16TabLeftCls = "TabLeft";
         if ( AV8Index == AV5FirstTab )
         {
            AV16TabLeftCls = "TabFirst";
         }
         AV17TabRightCls = "TabRight";
         if ( AV8Index == AV11LastTab )
         {
            AV17TabRightCls = "TabLast";
         }
         if ( AV8Index == AV13SelectedTab )
         {
            AV19TabsMarkup = AV19TabsMarkup + StringUtil.Format( AV20TabTemplate, "Tab TabSelected", AV14Tab.gxTpr_Code, "", AV16TabLeftCls, AV17TabRightCls, AV14Tab.gxTpr_Description, "", "", "");
            AssignAttri(sPrefix, false, "AV19TabsMarkup", AV19TabsMarkup);
            AV21WebComponentUrl = AV14Tab.gxTpr_Webcomponent;
            /* Object Property */
            gxDynCompUrl = AV21WebComponentUrl;
            if ( ! IsSameComponent( WebComp_Component_Component, gxDynCompUrl) )
            {
               WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", gxDynCompUrl, new Object[] {context} );
               WebComp_Component.ComponentInit();
               WebComp_Component.Name = "gxDynCompUrl";
               WebComp_Component_Component = gxDynCompUrl;
            }
            else
            {
               WebComp_Component.setparmsfromurl(gxDynCompUrl);
            }
            if ( StringUtil.Len( WebComp_Component_Component) != 0 )
            {
               WebComp_Component.setjustcreated();
               WebComp_Component.componentprepare(new Object[] {(String)sPrefix+"W0014",(String)""});
               WebComp_Component.componentbind(new Object[] {});
            }
            if ( isFullAjaxMode( ) )
            {
               context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0014"+"");
               WebComp_Component.componentdraw();
               context.httpAjaxContext.ajax_rspEndCmp();
            }
         }
         else
         {
            AV12OnClickTemplate = " onclick=\"return HistoryManager.AddHistoryPoint(" + "'%1'" + ", false, event)\"";
            AV19TabsMarkup = AV19TabsMarkup + StringUtil.Format( AV20TabTemplate, "Tab", AV14Tab.gxTpr_Code, StringUtil.Format( "href=\"%1\"", AV14Tab.gxTpr_Link, "", "", "", "", "", "", "", ""), AV16TabLeftCls, AV17TabRightCls, AV14Tab.gxTpr_Description, StringUtil.Format( AV12OnClickTemplate, AV14Tab.gxTpr_Code, "", "", "", "", "", "", "", ""), "", "");
            AssignAttri(sPrefix, false, "AV19TabsMarkup", AV19TabsMarkup);
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E140I2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_0I2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "none", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr style=\""+CSSHelper.Prettify( "vertical-align:bottom")+"\">") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:bottom;height:40px")+"\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divTabcontainer_Internalname, 1, 0, "px", 0, "px", "TabContainer", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTabs_Internalname, lblTabs_Caption, "", "", lblTabs_Jsonclick, "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", 0, "", 1, 1, 1, "HLP_TabbedView.htm");
            /* Static images/pictures */
            ClassString = "TabPagingPrevious";
            StyleString = "";
            sImgUrl = "(none)";
            GxWebStd.gx_bitmap( context, imgTabprevious_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgTabprevious_Visible, 1, "", "Previous Tab", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_TabbedView.htm");
            /* Static images/pictures */
            ClassString = "TabPagingNext";
            StyleString = "";
            sImgUrl = "(none)";
            GxWebStd.gx_bitmap( context, imgTabnext_Internalname, sImgUrl, "", "", "", context.GetTheme( ), imgTabnext_Visible, 1, "", "Next Tab", 0, 0, 0, "px", 0, "px", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_TabbedView.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:top;height:39px")+"\">") ;
            wb_table2_11_0I2( true) ;
         }
         else
         {
            wb_table2_11_0I2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_0I2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0I2e( true) ;
         }
         else
         {
            wb_table1_2_0I2e( false) ;
         }
      }

      protected void wb_table2_11_0I2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "TableBorder", 0, "", "", 0, 0, sStyleString, "none", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\""+CSSHelper.Prettify( "vertical-align:top")+"\">") ;
            if ( ! isFullAjaxMode( ) )
            {
               /* WebComponent */
               GxWebStd.gx_hidden_field( context, sPrefix+"W0014"+"", StringUtil.RTrim( WebComp_Component_Component));
               context.WriteHtmlText( "<div") ;
               GxWebStd.ClassAttribute( context, "gxwebcomponent");
               context.WriteHtmlText( " id=\""+sPrefix+"gxHTMLWrpW0014"+""+"\""+"") ;
               context.WriteHtmlText( ">") ;
               if ( StringUtil.Len( WebComp_Component_Component) != 0 )
               {
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldComponent), StringUtil.Lower( WebComp_Component_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0014"+"");
                  }
                  WebComp_Component.componentdraw();
                  if ( StringUtil.StrCmp(StringUtil.Lower( OldComponent), StringUtil.Lower( WebComp_Component_Component)) != 0 )
                  {
                     context.httpAjaxContext.ajax_rspEndCmp();
                  }
               }
               context.WriteHtmlText( "</div>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_0I2e( true) ;
         }
         else
         {
            wb_table2_11_0I2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV18Tabs = (GXBaseCollection<SdtTabOptions_TabOptionsItem>)getParm(obj,0);
         AV15TabCode = (String)getParm(obj,1);
         AssignAttri(sPrefix, false, "AV15TabCode", AV15TabCode);
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
         PA0I2( ) ;
         WS0I2( ) ;
         WE0I2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV18Tabs = (String)((String)getParm(obj,0));
         sCtrlAV15TabCode = (String)((String)getParm(obj,1));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA0I2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "tabbedview", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA0I2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV18Tabs = (GXBaseCollection<SdtTabOptions_TabOptionsItem>)getParm(obj,2);
            AV15TabCode = (String)getParm(obj,3);
            AssignAttri(sPrefix, false, "AV15TabCode", AV15TabCode);
         }
         wcpOAV15TabCode = cgiGet( sPrefix+"wcpOAV15TabCode");
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV15TabCode, wcpOAV15TabCode) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV15TabCode = AV15TabCode;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV18Tabs = cgiGet( sPrefix+"AV18Tabs_CTRL");
         if ( StringUtil.Len( sCtrlAV18Tabs) > 0 )
         {
            AV18Tabs = new GXBaseCollection<SdtTabOptions_TabOptionsItem>();
         }
         else
         {
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"AV18Tabs_PARM"), AV18Tabs);
         }
         sCtrlAV15TabCode = cgiGet( sPrefix+"AV15TabCode_CTRL");
         if ( StringUtil.Len( sCtrlAV15TabCode) > 0 )
         {
            AV15TabCode = cgiGet( sCtrlAV15TabCode);
            AssignAttri(sPrefix, false, "AV15TabCode", AV15TabCode);
         }
         else
         {
            AV15TabCode = cgiGet( sPrefix+"AV15TabCode_PARM");
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA0I2( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS0I2( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS0I2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"AV18Tabs_PARM", AV18Tabs);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"AV18Tabs_PARM", AV18Tabs);
         }
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV18Tabs)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV18Tabs_CTRL", StringUtil.RTrim( sCtrlAV18Tabs));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV15TabCode_PARM", StringUtil.RTrim( AV15TabCode));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV15TabCode)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV15TabCode_CTRL", StringUtil.RTrim( sCtrlAV15TabCode));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE0I2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
         if ( ! ( WebComp_Component == null ) )
         {
            WebComp_Component.componentjscripts();
         }
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         if ( ! ( WebComp_Component == null ) )
         {
            if ( StringUtil.Len( WebComp_Component_Component) != 0 )
            {
               WebComp_Component.componentthemes();
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202021621491037", true, true);
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
         context.AddJavascriptSource("tabbedview.js", "?202021621491037", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManager.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/json2005.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/rsh/rsh.js", "", false, true);
         context.AddJavascriptSource("Shared/HistoryManager/HistoryManagerCreate.js", "", false, true);
         /* End function include_jscripts */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblTabs_Internalname = sPrefix+"TABS";
         imgTabprevious_Internalname = sPrefix+"TABPREVIOUS";
         imgTabnext_Internalname = sPrefix+"TABNEXT";
         divTabcontainer_Internalname = sPrefix+"TABCONTAINER";
         tblTable2_Internalname = sPrefix+"TABLE2";
         tblTable1_Internalname = sPrefix+"TABLE1";
         Historymanager_Internalname = sPrefix+"HISTORYMANAGER";
         Form.Internalname = sPrefix+"FORM";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("Carmine");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         imgTabnext_Visible = 1;
         imgTabprevious_Visible = 1;
         lblTabs_Jsonclick = "";
         lblTabs_Backcolor = (int)(0xFFFFFF);
         lblTabs_Caption = "Tabs";
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV23URLChangedEvent',fld:'vURLCHANGEDEVENT',pic:''},{av:'AV5FirstTab',fld:'vFIRSTTAB',pic:'ZZZ9'},{av:'AV11LastTab',fld:'vLASTTAB',pic:'ZZZ9'},{av:'AV18Tabs',fld:'vTABS',pic:''},{av:'AV15TabCode',fld:'vTABCODE',pic:''},{av:'Historymanager_Hash',ctrl:'HISTORYMANAGER',prop:'Hash'},{av:'AV8Index',fld:'vINDEX',pic:'ZZZ9'},{av:'AV13SelectedTab',fld:'vSELECTEDTAB',pic:'ZZZ9'},{av:'AV14Tab',fld:'vTAB',pic:''},{av:'AV19TabsMarkup',fld:'vTABSMARKUP',pic:''},{av:'AV20TabTemplate',fld:'vTABTEMPLATE',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV19TabsMarkup',fld:'vTABSMARKUP',pic:''},{av:'AV8Index',fld:'vINDEX',pic:'ZZZ9'},{av:'AV14Tab',fld:'vTAB',pic:''},{av:'lblTabs_Caption',ctrl:'TABS',prop:'Caption'},{av:'AV13SelectedTab',fld:'vSELECTEDTAB',pic:'ZZZ9'},{av:'AV5FirstTab',fld:'vFIRSTTAB',pic:'ZZZ9'},{av:'AV11LastTab',fld:'vLASTTAB',pic:'ZZZ9'},{av:'imgTabprevious_Visible',ctrl:'TABPREVIOUS',prop:'Visible'},{av:'imgTabnext_Visible',ctrl:'TABNEXT',prop:'Visible'},{ctrl:'COMPONENT'}]}");
         setEventMetadata("HISTORYMANAGER.URLCHANGED","{handler:'E110I2',iparms:[{av:'AV5FirstTab',fld:'vFIRSTTAB',pic:'ZZZ9'},{av:'AV11LastTab',fld:'vLASTTAB',pic:'ZZZ9'},{av:'AV18Tabs',fld:'vTABS',pic:''},{av:'AV15TabCode',fld:'vTABCODE',pic:''},{av:'Historymanager_Hash',ctrl:'HISTORYMANAGER',prop:'Hash'},{av:'AV8Index',fld:'vINDEX',pic:'ZZZ9'},{av:'AV13SelectedTab',fld:'vSELECTEDTAB',pic:'ZZZ9'},{av:'AV14Tab',fld:'vTAB',pic:''},{av:'AV19TabsMarkup',fld:'vTABSMARKUP',pic:''},{av:'AV20TabTemplate',fld:'vTABTEMPLATE',pic:'',hsh:true}]");
         setEventMetadata("HISTORYMANAGER.URLCHANGED",",oparms:[{av:'AV23URLChangedEvent',fld:'vURLCHANGEDEVENT',pic:''},{av:'AV19TabsMarkup',fld:'vTABSMARKUP',pic:''},{av:'AV8Index',fld:'vINDEX',pic:'ZZZ9'},{av:'AV14Tab',fld:'vTAB',pic:''},{av:'lblTabs_Caption',ctrl:'TABS',prop:'Caption'},{av:'AV13SelectedTab',fld:'vSELECTEDTAB',pic:'ZZZ9'},{av:'AV5FirstTab',fld:'vFIRSTTAB',pic:'ZZZ9'},{av:'AV11LastTab',fld:'vLASTTAB',pic:'ZZZ9'},{av:'imgTabprevious_Visible',ctrl:'TABPREVIOUS',prop:'Visible'},{av:'imgTabnext_Visible',ctrl:'TABNEXT',prop:'Visible'},{ctrl:'COMPONENT'}]}");
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
         AV18Tabs = new GXBaseCollection<SdtTabOptions_TabOptionsItem>( context, "TabOptionsItem", "GXObligatorio1");
         wcpOAV15TabCode = "";
         Historymanager_Hash = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV20TabTemplate = "";
         GXKey = "";
         AV14Tab = new SdtTabOptions_TabOptionsItem(context);
         AV19TabsMarkup = "";
         GX_FocusControl = "";
         ucHistorymanager = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         OldComponent = "";
         WebComp_Component_Component = "";
         gxDynCompUrl = "";
         AV16TabLeftCls = "";
         AV17TabRightCls = "";
         AV21WebComponentUrl = "";
         AV12OnClickTemplate = "";
         sStyleString = "";
         ClassString = "";
         StyleString = "";
         sImgUrl = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV18Tabs = "";
         sCtrlAV15TabCode = "";
         WebComp_Component = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short AV5FirstTab ;
      private short AV11LastTab ;
      private short AV8Index ;
      private short AV13SelectedTab ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int imgTabprevious_Visible ;
      private int imgTabnext_Visible ;
      private int idxLst ;
      private int lblTabs_Backcolor ;
      private String AV15TabCode ;
      private String wcpOAV15TabCode ;
      private String Historymanager_Hash ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String AV20TabTemplate ;
      private String GXKey ;
      private String AV19TabsMarkup ;
      private String GX_FocusControl ;
      private String Historymanager_Internalname ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String OldComponent ;
      private String WebComp_Component_Component ;
      private String gxDynCompUrl ;
      private String lblTabs_Caption ;
      private String lblTabs_Internalname ;
      private String imgTabprevious_Internalname ;
      private String imgTabnext_Internalname ;
      private String AV16TabLeftCls ;
      private String AV17TabRightCls ;
      private String AV12OnClickTemplate ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String divTabcontainer_Internalname ;
      private String lblTabs_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String sImgUrl ;
      private String tblTable2_Internalname ;
      private String sCtrlAV18Tabs ;
      private String sCtrlAV15TabCode ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool AV23URLChangedEvent ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV9IsFirstTab ;
      private bool AV6Found ;
      private String AV21WebComponentUrl ;
      private GXWebComponent WebComp_Component ;
      private GXUserControl ucHistorymanager ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<SdtTabOptions_TabOptionsItem> AV18Tabs ;
      private SdtTabOptions_TabOptionsItem AV14Tab ;
   }

}