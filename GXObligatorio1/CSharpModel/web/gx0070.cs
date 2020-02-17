/*
               File: Gx0070
        Description: Selection List Espectaculo
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/16/2020 21:49:13.22
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
   public class gx0070 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0070( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx0070( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pEspectaculoId )
      {
         this.AV13pEspectaculoId = 0 ;
         executePrivate();
         aP0_pEspectaculoId=this.AV13pEspectaculoId;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_GXsfl_84 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_84_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_84_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid1_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               subGrid1_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV6cEspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cEspectaculoNombre = GetNextPar( );
               AV8cEspectaculoFecha = context.localUtil.ParseDateParm( GetNextPar( ));
               AV10cEspectaculoPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11cEspectaculoCiudadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12cLugarId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV15cLugarPaisId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cEspectaculoId, AV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               send_integrity_footer_hashes( ) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               AddString( context.getJSONResponse( )) ;
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
               AV13pEspectaculoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV13pEspectaculoId", StringUtil.LTrimStr( (decimal)(AV13pEspectaculoId), 4, 0));
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("rwdpromptmasterpage", "GeneXus.Programs.rwdpromptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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
         PA092( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START092( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202021621491327", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx0070.aspx") + "?" + UrlEncode("" +AV13pEspectaculoId)+"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCESPECTACULONOMBRE", StringUtil.RTrim( AV7cEspectaculoNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCESPECTACULOFECHA", context.localUtil.Format(AV8cEspectaculoFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCESPECTACULOPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cEspectaculoPaisId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCESPECTACULOCIUDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cEspectaculoCiudadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLUGARID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cLugarId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLUGARPAISID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cLugarPaisId), 4, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_84", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_84), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "ESPECTACULOIDFILTERCONTAINER_Class", StringUtil.RTrim( divEspectaculoidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESPECTACULONOMBREFILTERCONTAINER_Class", StringUtil.RTrim( divEspectaculonombrefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESPECTACULOFECHAFILTERCONTAINER_Class", StringUtil.RTrim( divEspectaculofechafiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESPECTACULOPAISIDFILTERCONTAINER_Class", StringUtil.RTrim( divEspectaculopaisidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "ESPECTACULOCIUDADIDFILTERCONTAINER_Class", StringUtil.RTrim( divEspectaculociudadidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LUGARIDFILTERCONTAINER_Class", StringUtil.RTrim( divLugaridfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LUGARPAISIDFILTERCONTAINER_Class", StringUtil.RTrim( divLugarpaisidfiltercontainer_Class));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", "notset");
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE092( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT092( ) ;
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
         return formatLink("gx0070.aspx") + "?" + UrlEncode("" +AV13pEspectaculoId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx0070" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Espectaculo" ;
      }

      protected void WB090( )
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
            GxWebStd.gx_div_start( context, divMain_Internalname, 1, 0, "px", 0, "px", "ContainerFluid PromptContainer", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 PromptAdvancedBarCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divAdvancedcontainer_Internalname, 1, 0, "px", 0, "px", divAdvancedcontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEspectaculoidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEspectaculoidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblespectaculoidfilter_Internalname, "Espectaculo Id", "", "", lblLblespectaculoidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e11091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCespectaculoid_Internalname, "Espectaculo Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCespectaculoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cEspectaculoId), 4, 0, ".", "")), ((edtavCespectaculoid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cEspectaculoId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cEspectaculoId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCespectaculoid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCespectaculoid_Visible, edtavCespectaculoid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEspectaculonombrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divEspectaculonombrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblespectaculonombrefilter_Internalname, "Espectaculo Nombre", "", "", lblLblespectaculonombrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e12091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCespectaculonombre_Internalname, "Espectaculo Nombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCespectaculonombre_Internalname, StringUtil.RTrim( AV7cEspectaculoNombre), StringUtil.RTrim( context.localUtil.Format( AV7cEspectaculoNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCespectaculonombre_Jsonclick, 0, "Attribute", "", "", "", "", edtavCespectaculonombre_Visible, edtavCespectaculonombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEspectaculofechafiltercontainer_Internalname, 1, 0, "px", 0, "px", divEspectaculofechafiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblespectaculofechafilter_Internalname, "Espectaculo Fecha", "", "", lblLblespectaculofechafilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e13091_client"+"'", "", "WWAdvancedLabel WWDateFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCespectaculofecha_Internalname, "Espectaculo Fecha", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_84_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavCespectaculofecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCespectaculofecha_Internalname, context.localUtil.Format(AV8cEspectaculoFecha, "99/99/99"), context.localUtil.Format( AV8cEspectaculoFecha, "99/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'MDY',0,12,'eng',false,0);"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCespectaculofecha_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavCespectaculofecha_Enabled, 0, "text", "", 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0070.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEspectaculopaisidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEspectaculopaisidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblespectaculopaisidfilter_Internalname, "Espectaculo Pais Id", "", "", lblLblespectaculopaisidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e14091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCespectaculopaisid_Internalname, "Espectaculo Pais Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCespectaculopaisid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cEspectaculoPaisId), 4, 0, ".", "")), ((edtavCespectaculopaisid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cEspectaculoPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV10cEspectaculoPaisId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCespectaculopaisid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCespectaculopaisid_Visible, edtavCespectaculopaisid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divEspectaculociudadidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divEspectaculociudadidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLblespectaculociudadidfilter_Internalname, "Espectaculo Ciudad Id", "", "", lblLblespectaculociudadidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e15091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavCespectaculociudadid_Internalname, "Espectaculo Ciudad Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavCespectaculociudadid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cEspectaculoCiudadId), 4, 0, ".", "")), ((edtavCespectaculociudadid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11cEspectaculoCiudadId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV11cEspectaculoCiudadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavCespectaculociudadid_Jsonclick, 0, "Attribute", "", "", "", "", edtavCespectaculociudadid_Visible, edtavCespectaculociudadid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLugaridfiltercontainer_Internalname, 1, 0, "px", 0, "px", divLugaridfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllugaridfilter_Internalname, "Lugar Id", "", "", lblLbllugaridfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e16091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClugarid_Internalname, "Lugar Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClugarid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cLugarId), 4, 0, ".", "")), ((edtavClugarid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV12cLugarId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV12cLugarId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClugarid_Jsonclick, 0, "Attribute", "", "", "", "", edtavClugarid_Visible, edtavClugarid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLugarpaisidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divLugarpaisidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllugarpaisidfilter_Internalname, "Lugar Pais Id", "", "", lblLbllugarpaisidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e17091_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClugarpaisid_Internalname, "Lugar Pais Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_84_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClugarpaisid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cLugarPaisId), 4, 0, ".", "")), ((edtavClugarpaisid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV15cLugarPaisId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV15cLugarPaisId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClugarpaisid_Jsonclick, 0, "Attribute", "", "", "", "", edtavClugarpaisid_Visible, edtavClugarpaisid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 WWGridCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 hidden-sm hidden-md hidden-lg ToggleCell", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e18091_client"+"'", TempTags, "", 2, "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"84\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "PromptGrid", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title";
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DescriptionAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "Lugar Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Header", subGrid1_Header);
               Grid1Container.AddObjectProperty("Class", "PromptGrid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A35EspectaculoNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtEspectaculoNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectedindex), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowselection), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowhovering), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Allowcollapsing), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            nRC_GXsfl_84 = (int)(nGXsfl_84_idx-1);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
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
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(84), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx0070.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 84 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( Grid1Container.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
                  Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
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
            }
         }
         wbLoad = true;
      }

      protected void START092( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Selection List Espectaculo", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP090( ) ;
      }

      protected void WS092( )
      {
         START092( ) ;
         EVT092( ) ;
      }

      protected void EVT092( )
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
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1;
                              sEvt = cgiGet( "GRID1PAGING");
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_84_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
                              SubsflControlProps_842( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_84_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                              A35EspectaculoNombre = cgiGet( edtEspectaculoNombre_Internalname);
                              A8LugarId = (short)(context.localUtil.CToN( cgiGet( edtLugarId_Internalname), ".", ","));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E19092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E20092 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Cespectaculoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOID"), ".", ",") != Convert.ToDecimal( AV6cEspectaculoId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cespectaculonombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCESPECTACULONOMBRE"), AV7cEspectaculoNombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cespectaculofecha Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vCESPECTACULOFECHA"), 0) != AV8cEspectaculoFecha )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cespectaculopaisid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOPAISID"), ".", ",") != Convert.ToDecimal( AV10cEspectaculoPaisId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Cespectaculociudadid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOCIUDADID"), ".", ",") != Convert.ToDecimal( AV11cEspectaculoCiudadId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clugarid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLUGARID"), ".", ",") != Convert.ToDecimal( AV12cLugarId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clugarpaisid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLUGARPAISID"), ".", ",") != Convert.ToDecimal( AV15cLugarPaisId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E21092 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE092( )
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

      protected void PA092( )
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
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_842( ) ;
         while ( nGXsfl_84_idx <= nRC_GXsfl_84 )
         {
            sendrow_842( ) ;
            nGXsfl_84_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1);
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
            SubsflControlProps_842( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cEspectaculoId ,
                                        String AV7cEspectaculoNombre ,
                                        DateTime AV8cEspectaculoFecha ,
                                        short AV10cEspectaculoPaisId ,
                                        short AV11cEspectaculoCiudadId ,
                                        short AV12cLugarId ,
                                        short AV15cLugarPaisId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF092( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ESPECTACULOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "ESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
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
         RF092( ) ;
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

      protected void RF092( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 84;
         nGXsfl_84_idx = 1;
         sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
         SubsflControlProps_842( ) ;
         bGXsfl_84_Refreshing = true;
         Grid1Container.AddObjectProperty("GridName", "Grid1");
         Grid1Container.AddObjectProperty("CmpContext", "");
         Grid1Container.AddObjectProperty("InMasterPage", "false");
         Grid1Container.AddObjectProperty("Class", "PromptGrid");
         Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
         Grid1Container.PageSize = subGrid1_fnc_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_842( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cEspectaculoNombre ,
                                                 AV8cEspectaculoFecha ,
                                                 AV10cEspectaculoPaisId ,
                                                 AV11cEspectaculoCiudadId ,
                                                 AV12cLugarId ,
                                                 AV15cLugarPaisId ,
                                                 A35EspectaculoNombre ,
                                                 A36EspectaculoFecha ,
                                                 A19EspectaculoPaisId ,
                                                 A22EspectaculoCiudadId ,
                                                 A8LugarId ,
                                                 A29LugarPaisId ,
                                                 AV6cEspectaculoId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                                 }
            } ) ;
            lV7cEspectaculoNombre = StringUtil.PadR( StringUtil.RTrim( AV7cEspectaculoNombre), 100, "%");
            /* Using cursor H00092 */
            pr_default.execute(0, new Object[] {AV6cEspectaculoId, lV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_84_idx = 1;
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
            SubsflControlProps_842( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A29LugarPaisId = H00092_A29LugarPaisId[0];
               A22EspectaculoCiudadId = H00092_A22EspectaculoCiudadId[0];
               A19EspectaculoPaisId = H00092_A19EspectaculoPaisId[0];
               A36EspectaculoFecha = H00092_A36EspectaculoFecha[0];
               A8LugarId = H00092_A8LugarId[0];
               A35EspectaculoNombre = H00092_A35EspectaculoNombre[0];
               A34EspectaculoId = H00092_A34EspectaculoId[0];
               /* Execute user event: Load */
               E20092 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 84;
            WB090( ) ;
         }
         bGXsfl_84_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes092( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_ESPECTACULOID"+"_"+sGXsfl_84_idx, GetSecureSignedToken( sGXsfl_84_idx, context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"), context));
      }

      protected int subGrid1_fnc_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_fnc_Recordcount( )
      {
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV7cEspectaculoNombre ,
                                              AV8cEspectaculoFecha ,
                                              AV10cEspectaculoPaisId ,
                                              AV11cEspectaculoCiudadId ,
                                              AV12cLugarId ,
                                              AV15cLugarPaisId ,
                                              A35EspectaculoNombre ,
                                              A36EspectaculoFecha ,
                                              A19EspectaculoPaisId ,
                                              A22EspectaculoCiudadId ,
                                              A8LugarId ,
                                              A29LugarPaisId ,
                                              AV6cEspectaculoId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT
                                              }
         } ) ;
         lV7cEspectaculoNombre = StringUtil.PadR( StringUtil.RTrim( AV7cEspectaculoNombre), 100, "%");
         /* Using cursor H00093 */
         pr_default.execute(1, new Object[] {AV6cEspectaculoId, lV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId});
         GRID1_nRecordCount = H00093_AGRID1_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID1_nRecordCount) ;
      }

      protected int subGrid1_fnc_Recordsperpage( )
      {
         return (int)(10*1) ;
      }

      protected int subGrid1_fnc_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_fnc_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEspectaculoId, AV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( ( GRID1_nRecordCount >= subGrid1_fnc_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage+subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEspectaculoId, AV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID1_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_fnc_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (long)(GRID1_nFirstRecordOnPage-subGrid1_fnc_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEspectaculoId, AV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_fnc_Recordcount( );
         if ( GRID1_nRecordCount > subGrid1_fnc_Recordsperpage( ) )
         {
            if ( ((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-subGrid1_fnc_Recordsperpage( ));
            }
            else
            {
               GRID1_nFirstRecordOnPage = (long)(GRID1_nRecordCount-((int)((GRID1_nRecordCount) % (subGrid1_fnc_Recordsperpage( )))));
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEspectaculoId, AV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (long)(subGrid1_fnc_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid1_refresh( subGrid1_Rows, AV6cEspectaculoId, AV7cEspectaculoNombre, AV8cEspectaculoFecha, AV10cEspectaculoPaisId, AV11cEspectaculoCiudadId, AV12cLugarId, AV15cLugarPaisId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP090( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E19092 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_84 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_84"), ".", ","));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCespectaculoid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCespectaculoid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCESPECTACULOID");
               GX_FocusControl = edtavCespectaculoid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cEspectaculoId = 0;
               AssignAttri("", false, "AV6cEspectaculoId", StringUtil.LTrimStr( (decimal)(AV6cEspectaculoId), 4, 0));
            }
            else
            {
               AV6cEspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtavCespectaculoid_Internalname), ".", ","));
               AssignAttri("", false, "AV6cEspectaculoId", StringUtil.LTrimStr( (decimal)(AV6cEspectaculoId), 4, 0));
            }
            AV7cEspectaculoNombre = cgiGet( edtavCespectaculonombre_Internalname);
            AssignAttri("", false, "AV7cEspectaculoNombre", AV7cEspectaculoNombre);
            if ( context.localUtil.VCDate( cgiGet( edtavCespectaculofecha_Internalname), 1) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Espectaculo Fecha"}), 1, "vCESPECTACULOFECHA");
               GX_FocusControl = edtavCespectaculofecha_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cEspectaculoFecha = DateTime.MinValue;
               AssignAttri("", false, "AV8cEspectaculoFecha", context.localUtil.Format(AV8cEspectaculoFecha, "99/99/99"));
            }
            else
            {
               AV8cEspectaculoFecha = context.localUtil.CToD( cgiGet( edtavCespectaculofecha_Internalname), 1);
               AssignAttri("", false, "AV8cEspectaculoFecha", context.localUtil.Format(AV8cEspectaculoFecha, "99/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCespectaculopaisid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCespectaculopaisid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCESPECTACULOPAISID");
               GX_FocusControl = edtavCespectaculopaisid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cEspectaculoPaisId = 0;
               AssignAttri("", false, "AV10cEspectaculoPaisId", StringUtil.LTrimStr( (decimal)(AV10cEspectaculoPaisId), 4, 0));
            }
            else
            {
               AV10cEspectaculoPaisId = (short)(context.localUtil.CToN( cgiGet( edtavCespectaculopaisid_Internalname), ".", ","));
               AssignAttri("", false, "AV10cEspectaculoPaisId", StringUtil.LTrimStr( (decimal)(AV10cEspectaculoPaisId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCespectaculociudadid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCespectaculociudadid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCESPECTACULOCIUDADID");
               GX_FocusControl = edtavCespectaculociudadid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11cEspectaculoCiudadId = 0;
               AssignAttri("", false, "AV11cEspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(AV11cEspectaculoCiudadId), 4, 0));
            }
            else
            {
               AV11cEspectaculoCiudadId = (short)(context.localUtil.CToN( cgiGet( edtavCespectaculociudadid_Internalname), ".", ","));
               AssignAttri("", false, "AV11cEspectaculoCiudadId", StringUtil.LTrimStr( (decimal)(AV11cEspectaculoCiudadId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClugarid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClugarid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLUGARID");
               GX_FocusControl = edtavClugarid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV12cLugarId = 0;
               AssignAttri("", false, "AV12cLugarId", StringUtil.LTrimStr( (decimal)(AV12cLugarId), 4, 0));
            }
            else
            {
               AV12cLugarId = (short)(context.localUtil.CToN( cgiGet( edtavClugarid_Internalname), ".", ","));
               AssignAttri("", false, "AV12cLugarId", StringUtil.LTrimStr( (decimal)(AV12cLugarId), 4, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClugarpaisid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClugarpaisid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLUGARPAISID");
               GX_FocusControl = edtavClugarpaisid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV15cLugarPaisId = 0;
               AssignAttri("", false, "AV15cLugarPaisId", StringUtil.LTrimStr( (decimal)(AV15cLugarPaisId), 4, 0));
            }
            else
            {
               AV15cLugarPaisId = (short)(context.localUtil.CToN( cgiGet( edtavClugarpaisid_Internalname), ".", ","));
               AssignAttri("", false, "AV15cLugarPaisId", StringUtil.LTrimStr( (decimal)(AV15cLugarPaisId), 4, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOID"), ".", ",") != Convert.ToDecimal( AV6cEspectaculoId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCESPECTACULONOMBRE"), AV7cEspectaculoNombre) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vCESPECTACULOFECHA"), 1) != AV8cEspectaculoFecha )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOPAISID"), ".", ",") != Convert.ToDecimal( AV10cEspectaculoPaisId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESPECTACULOCIUDADID"), ".", ",") != Convert.ToDecimal( AV11cEspectaculoCiudadId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLUGARID"), ".", ",") != Convert.ToDecimal( AV12cLugarId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLUGARPAISID"), ".", ",") != Convert.ToDecimal( AV15cLugarPaisId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
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
         E19092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19092( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Espectaculo", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV14ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E20092( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV18Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_842( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_84_Refreshing )
         {
            context.DoAjaxLoad(84, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E21092 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21092( )
      {
         /* Enter Routine */
         AV13pEspectaculoId = A34EspectaculoId;
         AssignAttri("", false, "AV13pEspectaculoId", StringUtil.LTrimStr( (decimal)(AV13pEspectaculoId), 4, 0));
         context.setWebReturnParms(new Object[] {(short)AV13pEspectaculoId});
         context.setWebReturnParmsMetadata(new Object[] {"AV13pEspectaculoId"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pEspectaculoId = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV13pEspectaculoId", StringUtil.LTrimStr( (decimal)(AV13pEspectaculoId), 4, 0));
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
         PA092( ) ;
         WS092( ) ;
         WE092( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202021621491376", true, true);
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
         context.AddJavascriptSource("gx0070.js", "?202021621491376", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_84_idx;
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE_"+sGXsfl_84_idx;
         edtLugarId_Internalname = "LUGARID_"+sGXsfl_84_idx;
      }

      protected void SubsflControlProps_fel_842( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_84_fel_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_84_fel_idx;
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE_"+sGXsfl_84_fel_idx;
         edtLugarId_Internalname = "LUGARID_"+sGXsfl_84_fel_idx;
      }

      protected void sendrow_842( )
      {
         SubsflControlProps_842( ) ;
         WB090( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_84_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container);
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
               subGrid1_Backcolor = (int)(0x0);
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1;
               if ( ((int)((nGXsfl_84_idx) % (2))) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even";
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd";
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"PromptGrid"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_84_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_84_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV18Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV18Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtEspectaculoNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtEspectaculoNombre_Internalname, "Link", edtEspectaculoNombre_Link, !bGXsfl_84_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoNombre_Internalname,StringUtil.RTrim( A35EspectaculoNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtEspectaculoNombre_Link,(String)"",(String)"",(String)"",(String)edtEspectaculoNombre_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLugarId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A8LugarId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A8LugarId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLugarId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn OptionalColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)84,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            send_integrity_lvl_hashes092( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_84_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_84_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_84_idx+1);
            sGXsfl_84_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_84_idx), 4, 0), 4, "0");
            SubsflControlProps_842( ) ;
         }
         /* End function sendrow_842 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLblespectaculoidfilter_Internalname = "LBLESPECTACULOIDFILTER";
         edtavCespectaculoid_Internalname = "vCESPECTACULOID";
         divEspectaculoidfiltercontainer_Internalname = "ESPECTACULOIDFILTERCONTAINER";
         lblLblespectaculonombrefilter_Internalname = "LBLESPECTACULONOMBREFILTER";
         edtavCespectaculonombre_Internalname = "vCESPECTACULONOMBRE";
         divEspectaculonombrefiltercontainer_Internalname = "ESPECTACULONOMBREFILTERCONTAINER";
         lblLblespectaculofechafilter_Internalname = "LBLESPECTACULOFECHAFILTER";
         edtavCespectaculofecha_Internalname = "vCESPECTACULOFECHA";
         divEspectaculofechafiltercontainer_Internalname = "ESPECTACULOFECHAFILTERCONTAINER";
         lblLblespectaculopaisidfilter_Internalname = "LBLESPECTACULOPAISIDFILTER";
         edtavCespectaculopaisid_Internalname = "vCESPECTACULOPAISID";
         divEspectaculopaisidfiltercontainer_Internalname = "ESPECTACULOPAISIDFILTERCONTAINER";
         lblLblespectaculociudadidfilter_Internalname = "LBLESPECTACULOCIUDADIDFILTER";
         edtavCespectaculociudadid_Internalname = "vCESPECTACULOCIUDADID";
         divEspectaculociudadidfiltercontainer_Internalname = "ESPECTACULOCIUDADIDFILTERCONTAINER";
         lblLbllugaridfilter_Internalname = "LBLLUGARIDFILTER";
         edtavClugarid_Internalname = "vCLUGARID";
         divLugaridfiltercontainer_Internalname = "LUGARIDFILTERCONTAINER";
         lblLbllugarpaisidfilter_Internalname = "LBLLUGARPAISIDFILTER";
         edtavClugarpaisid_Internalname = "vCLUGARPAISID";
         divLugarpaisidfiltercontainer_Internalname = "LUGARPAISIDFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtEspectaculoId_Internalname = "ESPECTACULOID";
         edtEspectaculoNombre_Internalname = "ESPECTACULONOMBRE";
         edtLugarId_Internalname = "LUGARID";
         bttBtn_cancel_Internalname = "BTN_CANCEL";
         divGridtable_Internalname = "GRIDTABLE";
         divMain_Internalname = "MAIN";
         Form.Internalname = "FORM";
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
         edtLugarId_Jsonclick = "";
         edtEspectaculoNombre_Jsonclick = "";
         edtEspectaculoId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtEspectaculoNombre_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavClugarpaisid_Jsonclick = "";
         edtavClugarpaisid_Enabled = 1;
         edtavClugarpaisid_Visible = 1;
         edtavClugarid_Jsonclick = "";
         edtavClugarid_Enabled = 1;
         edtavClugarid_Visible = 1;
         edtavCespectaculociudadid_Jsonclick = "";
         edtavCespectaculociudadid_Enabled = 1;
         edtavCespectaculociudadid_Visible = 1;
         edtavCespectaculopaisid_Jsonclick = "";
         edtavCespectaculopaisid_Enabled = 1;
         edtavCespectaculopaisid_Visible = 1;
         edtavCespectaculofecha_Jsonclick = "";
         edtavCespectaculofecha_Enabled = 1;
         edtavCespectaculonombre_Jsonclick = "";
         edtavCespectaculonombre_Enabled = 1;
         edtavCespectaculonombre_Visible = 1;
         edtavCespectaculoid_Jsonclick = "";
         edtavCespectaculoid_Enabled = 1;
         edtavCespectaculoid_Visible = 1;
         divLugarpaisidfiltercontainer_Class = "AdvancedContainerItem";
         divLugaridfiltercontainer_Class = "AdvancedContainerItem";
         divEspectaculociudadidfiltercontainer_Class = "AdvancedContainerItem";
         divEspectaculopaisidfiltercontainer_Class = "AdvancedContainerItem";
         divEspectaculofechafiltercontainer_Class = "AdvancedContainerItem";
         divEspectaculonombrefiltercontainer_Class = "AdvancedContainerItem";
         divEspectaculoidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Espectaculo";
         subGrid1_Rows = 10;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV7cEspectaculoNombre',fld:'vCESPECTACULONOMBRE',pic:''},{av:'AV8cEspectaculoFecha',fld:'vCESPECTACULOFECHA',pic:''},{av:'AV10cEspectaculoPaisId',fld:'vCESPECTACULOPAISID',pic:'ZZZ9'},{av:'AV11cEspectaculoCiudadId',fld:'vCESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'AV12cLugarId',fld:'vCLUGARID',pic:'ZZZ9'},{av:'AV15cLugarPaisId',fld:'vCLUGARPAISID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E18091',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLESPECTACULOIDFILTER.CLICK","{handler:'E11091',iparms:[{av:'divEspectaculoidfiltercontainer_Class',ctrl:'ESPECTACULOIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLESPECTACULOIDFILTER.CLICK",",oparms:[{av:'divEspectaculoidfiltercontainer_Class',ctrl:'ESPECTACULOIDFILTERCONTAINER',prop:'Class'},{av:'edtavCespectaculoid_Visible',ctrl:'vCESPECTACULOID',prop:'Visible'}]}");
         setEventMetadata("LBLESPECTACULONOMBREFILTER.CLICK","{handler:'E12091',iparms:[{av:'divEspectaculonombrefiltercontainer_Class',ctrl:'ESPECTACULONOMBREFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLESPECTACULONOMBREFILTER.CLICK",",oparms:[{av:'divEspectaculonombrefiltercontainer_Class',ctrl:'ESPECTACULONOMBREFILTERCONTAINER',prop:'Class'},{av:'edtavCespectaculonombre_Visible',ctrl:'vCESPECTACULONOMBRE',prop:'Visible'}]}");
         setEventMetadata("LBLESPECTACULOFECHAFILTER.CLICK","{handler:'E13091',iparms:[{av:'divEspectaculofechafiltercontainer_Class',ctrl:'ESPECTACULOFECHAFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLESPECTACULOFECHAFILTER.CLICK",",oparms:[{av:'divEspectaculofechafiltercontainer_Class',ctrl:'ESPECTACULOFECHAFILTERCONTAINER',prop:'Class'}]}");
         setEventMetadata("LBLESPECTACULOPAISIDFILTER.CLICK","{handler:'E14091',iparms:[{av:'divEspectaculopaisidfiltercontainer_Class',ctrl:'ESPECTACULOPAISIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLESPECTACULOPAISIDFILTER.CLICK",",oparms:[{av:'divEspectaculopaisidfiltercontainer_Class',ctrl:'ESPECTACULOPAISIDFILTERCONTAINER',prop:'Class'},{av:'edtavCespectaculopaisid_Visible',ctrl:'vCESPECTACULOPAISID',prop:'Visible'}]}");
         setEventMetadata("LBLESPECTACULOCIUDADIDFILTER.CLICK","{handler:'E15091',iparms:[{av:'divEspectaculociudadidfiltercontainer_Class',ctrl:'ESPECTACULOCIUDADIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLESPECTACULOCIUDADIDFILTER.CLICK",",oparms:[{av:'divEspectaculociudadidfiltercontainer_Class',ctrl:'ESPECTACULOCIUDADIDFILTERCONTAINER',prop:'Class'},{av:'edtavCespectaculociudadid_Visible',ctrl:'vCESPECTACULOCIUDADID',prop:'Visible'}]}");
         setEventMetadata("LBLLUGARIDFILTER.CLICK","{handler:'E16091',iparms:[{av:'divLugaridfiltercontainer_Class',ctrl:'LUGARIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLUGARIDFILTER.CLICK",",oparms:[{av:'divLugaridfiltercontainer_Class',ctrl:'LUGARIDFILTERCONTAINER',prop:'Class'},{av:'edtavClugarid_Visible',ctrl:'vCLUGARID',prop:'Visible'}]}");
         setEventMetadata("LBLLUGARPAISIDFILTER.CLICK","{handler:'E17091',iparms:[{av:'divLugarpaisidfiltercontainer_Class',ctrl:'LUGARPAISIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLUGARPAISIDFILTER.CLICK",",oparms:[{av:'divLugarpaisidfiltercontainer_Class',ctrl:'LUGARPAISIDFILTERCONTAINER',prop:'Class'},{av:'edtavClugarpaisid_Visible',ctrl:'vCLUGARPAISID',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E21092',iparms:[{av:'A34EspectaculoId',fld:'ESPECTACULOID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV13pEspectaculoId',fld:'vPESPECTACULOID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV7cEspectaculoNombre',fld:'vCESPECTACULONOMBRE',pic:''},{av:'AV8cEspectaculoFecha',fld:'vCESPECTACULOFECHA',pic:''},{av:'AV10cEspectaculoPaisId',fld:'vCESPECTACULOPAISID',pic:'ZZZ9'},{av:'AV11cEspectaculoCiudadId',fld:'vCESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'AV12cLugarId',fld:'vCLUGARID',pic:'ZZZ9'},{av:'AV15cLugarPaisId',fld:'vCLUGARPAISID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV7cEspectaculoNombre',fld:'vCESPECTACULONOMBRE',pic:''},{av:'AV8cEspectaculoFecha',fld:'vCESPECTACULOFECHA',pic:''},{av:'AV10cEspectaculoPaisId',fld:'vCESPECTACULOPAISID',pic:'ZZZ9'},{av:'AV11cEspectaculoCiudadId',fld:'vCESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'AV12cLugarId',fld:'vCLUGARID',pic:'ZZZ9'},{av:'AV15cLugarPaisId',fld:'vCLUGARPAISID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV7cEspectaculoNombre',fld:'vCESPECTACULONOMBRE',pic:''},{av:'AV8cEspectaculoFecha',fld:'vCESPECTACULOFECHA',pic:''},{av:'AV10cEspectaculoPaisId',fld:'vCESPECTACULOPAISID',pic:'ZZZ9'},{av:'AV11cEspectaculoCiudadId',fld:'vCESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'AV12cLugarId',fld:'vCLUGARID',pic:'ZZZ9'},{av:'AV15cLugarPaisId',fld:'vCLUGARPAISID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cEspectaculoId',fld:'vCESPECTACULOID',pic:'ZZZ9'},{av:'AV7cEspectaculoNombre',fld:'vCESPECTACULONOMBRE',pic:''},{av:'AV8cEspectaculoFecha',fld:'vCESPECTACULOFECHA',pic:''},{av:'AV10cEspectaculoPaisId',fld:'vCESPECTACULOPAISID',pic:'ZZZ9'},{av:'AV11cEspectaculoCiudadId',fld:'vCESPECTACULOCIUDADID',pic:'ZZZ9'},{av:'AV12cLugarId',fld:'vCLUGARID',pic:'ZZZ9'},{av:'AV15cLugarPaisId',fld:'vCLUGARPAISID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("VALIDV_CESPECTACULOFECHA","{handler:'Validv_Cespectaculofecha',iparms:[]");
         setEventMetadata("VALIDV_CESPECTACULOFECHA",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Lugarid',iparms:[]");
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV7cEspectaculoNombre = "";
         AV8cEspectaculoFecha = DateTime.MinValue;
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLblespectaculoidfilter_Jsonclick = "";
         TempTags = "";
         lblLblespectaculonombrefilter_Jsonclick = "";
         lblLblespectaculofechafilter_Jsonclick = "";
         lblLblespectaculopaisidfilter_Jsonclick = "";
         lblLblespectaculociudadidfilter_Jsonclick = "";
         lblLbllugaridfilter_Jsonclick = "";
         lblLbllugarpaisidfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A35EspectaculoNombre = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV18Linkselection_GXI = "";
         scmdbuf = "";
         lV7cEspectaculoNombre = "";
         A36EspectaculoFecha = DateTime.MinValue;
         H00092_A29LugarPaisId = new short[1] ;
         H00092_A22EspectaculoCiudadId = new short[1] ;
         H00092_A19EspectaculoPaisId = new short[1] ;
         H00092_A36EspectaculoFecha = new DateTime[] {DateTime.MinValue} ;
         H00092_A8LugarId = new short[1] ;
         H00092_A35EspectaculoNombre = new String[] {""} ;
         H00092_A34EspectaculoId = new short[1] ;
         H00093_AGRID1_nRecordCount = new long[1] ;
         AV14ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0070__default(),
            new Object[][] {
                new Object[] {
               H00092_A29LugarPaisId, H00092_A22EspectaculoCiudadId, H00092_A19EspectaculoPaisId, H00092_A36EspectaculoFecha, H00092_A8LugarId, H00092_A35EspectaculoNombre, H00092_A34EspectaculoId
               }
               , new Object[] {
               H00093_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short GRID1_nEOF ;
      private short AV6cEspectaculoId ;
      private short AV10cEspectaculoPaisId ;
      private short AV11cEspectaculoCiudadId ;
      private short AV12cLugarId ;
      private short AV15cLugarPaisId ;
      private short AV13pEspectaculoId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A34EspectaculoId ;
      private short A8LugarId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short A19EspectaculoPaisId ;
      private short A22EspectaculoCiudadId ;
      private short A29LugarPaisId ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_84 ;
      private int nGXsfl_84_idx=1 ;
      private int subGrid1_Rows ;
      private int edtavCespectaculoid_Enabled ;
      private int edtavCespectaculoid_Visible ;
      private int edtavCespectaculonombre_Visible ;
      private int edtavCespectaculonombre_Enabled ;
      private int edtavCespectaculofecha_Enabled ;
      private int edtavCespectaculopaisid_Enabled ;
      private int edtavCespectaculopaisid_Visible ;
      private int edtavCespectaculociudadid_Enabled ;
      private int edtavCespectaculociudadid_Visible ;
      private int edtavClugarid_Enabled ;
      private int edtavClugarid_Visible ;
      private int edtavClugarpaisid_Enabled ;
      private int edtavClugarpaisid_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divEspectaculoidfiltercontainer_Class ;
      private String divEspectaculonombrefiltercontainer_Class ;
      private String divEspectaculofechafiltercontainer_Class ;
      private String divEspectaculopaisidfiltercontainer_Class ;
      private String divEspectaculociudadidfiltercontainer_Class ;
      private String divLugaridfiltercontainer_Class ;
      private String divLugarpaisidfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_84_idx="0001" ;
      private String AV7cEspectaculoNombre ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divEspectaculoidfiltercontainer_Internalname ;
      private String lblLblespectaculoidfilter_Internalname ;
      private String lblLblespectaculoidfilter_Jsonclick ;
      private String edtavCespectaculoid_Internalname ;
      private String TempTags ;
      private String edtavCespectaculoid_Jsonclick ;
      private String divEspectaculonombrefiltercontainer_Internalname ;
      private String lblLblespectaculonombrefilter_Internalname ;
      private String lblLblespectaculonombrefilter_Jsonclick ;
      private String edtavCespectaculonombre_Internalname ;
      private String edtavCespectaculonombre_Jsonclick ;
      private String divEspectaculofechafiltercontainer_Internalname ;
      private String lblLblespectaculofechafilter_Internalname ;
      private String lblLblespectaculofechafilter_Jsonclick ;
      private String edtavCespectaculofecha_Internalname ;
      private String edtavCespectaculofecha_Jsonclick ;
      private String divEspectaculopaisidfiltercontainer_Internalname ;
      private String lblLblespectaculopaisidfilter_Internalname ;
      private String lblLblespectaculopaisidfilter_Jsonclick ;
      private String edtavCespectaculopaisid_Internalname ;
      private String edtavCespectaculopaisid_Jsonclick ;
      private String divEspectaculociudadidfiltercontainer_Internalname ;
      private String lblLblespectaculociudadidfilter_Internalname ;
      private String lblLblespectaculociudadidfilter_Jsonclick ;
      private String edtavCespectaculociudadid_Internalname ;
      private String edtavCespectaculociudadid_Jsonclick ;
      private String divLugaridfiltercontainer_Internalname ;
      private String lblLbllugaridfilter_Internalname ;
      private String lblLbllugaridfilter_Jsonclick ;
      private String edtavClugarid_Internalname ;
      private String edtavClugarid_Jsonclick ;
      private String divLugarpaisidfiltercontainer_Internalname ;
      private String lblLbllugarpaisidfilter_Internalname ;
      private String lblLbllugarpaisidfilter_Jsonclick ;
      private String edtavClugarpaisid_Internalname ;
      private String edtavClugarpaisid_Jsonclick ;
      private String divGridtable_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtntoggle_Internalname ;
      private String bttBtntoggle_Jsonclick ;
      private String sStyleString ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String subGrid1_Header ;
      private String edtavLinkselection_Link ;
      private String A35EspectaculoNombre ;
      private String edtEspectaculoNombre_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtEspectaculoId_Internalname ;
      private String edtEspectaculoNombre_Internalname ;
      private String edtLugarId_Internalname ;
      private String scmdbuf ;
      private String lV7cEspectaculoNombre ;
      private String AV14ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_84_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtEspectaculoId_Jsonclick ;
      private String edtEspectaculoNombre_Jsonclick ;
      private String edtLugarId_Jsonclick ;
      private DateTime AV8cEspectaculoFecha ;
      private DateTime A36EspectaculoFecha ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_84_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV18Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H00092_A29LugarPaisId ;
      private short[] H00092_A22EspectaculoCiudadId ;
      private short[] H00092_A19EspectaculoPaisId ;
      private DateTime[] H00092_A36EspectaculoFecha ;
      private short[] H00092_A8LugarId ;
      private String[] H00092_A35EspectaculoNombre ;
      private short[] H00092_A34EspectaculoId ;
      private long[] H00093_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pEspectaculoId ;
      private GXWebForm Form ;
   }

   public class gx0070__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00092( IGxContext context ,
                                             String AV7cEspectaculoNombre ,
                                             DateTime AV8cEspectaculoFecha ,
                                             short AV10cEspectaculoPaisId ,
                                             short AV11cEspectaculoCiudadId ,
                                             short AV12cLugarId ,
                                             short AV15cLugarPaisId ,
                                             String A35EspectaculoNombre ,
                                             DateTime A36EspectaculoFecha ,
                                             short A19EspectaculoPaisId ,
                                             short A22EspectaculoCiudadId ,
                                             short A8LugarId ,
                                             short A29LugarPaisId ,
                                             short AV6cEspectaculoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [10] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [LugarPaisId], [EspectaculoCiudadId], [EspectaculoPaisId], [EspectaculoFecha], [LugarId], [EspectaculoNombre], [EspectaculoId]";
         sFromString = " FROM [Espectaculo]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EspectaculoId] >= @AV6cEspectaculoId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cEspectaculoNombre)) )
         {
            sWhereString = sWhereString + " and ([EspectaculoNombre] like @lV7cEspectaculoNombre)";
         }
         else
         {
            GXv_int1[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV8cEspectaculoFecha) )
         {
            sWhereString = sWhereString + " and ([EspectaculoFecha] >= @AV8cEspectaculoFecha)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV10cEspectaculoPaisId) )
         {
            sWhereString = sWhereString + " and ([EspectaculoPaisId] >= @AV10cEspectaculoPaisId)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (0==AV11cEspectaculoCiudadId) )
         {
            sWhereString = sWhereString + " and ([EspectaculoCiudadId] >= @AV11cEspectaculoCiudadId)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV12cLugarId) )
         {
            sWhereString = sWhereString + " and ([LugarId] >= @AV12cLugarId)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         if ( ! (0==AV15cLugarPaisId) )
         {
            sWhereString = sWhereString + " and ([LugarPaisId] >= @AV15cLugarPaisId)";
         }
         else
         {
            GXv_int1[6] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EspectaculoId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H00093( IGxContext context ,
                                             String AV7cEspectaculoNombre ,
                                             DateTime AV8cEspectaculoFecha ,
                                             short AV10cEspectaculoPaisId ,
                                             short AV11cEspectaculoCiudadId ,
                                             short AV12cLugarId ,
                                             short AV15cLugarPaisId ,
                                             String A35EspectaculoNombre ,
                                             DateTime A36EspectaculoFecha ,
                                             short A19EspectaculoPaisId ,
                                             short A22EspectaculoCiudadId ,
                                             short A8LugarId ,
                                             short A29LugarPaisId ,
                                             short AV6cEspectaculoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [7] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [Espectaculo]";
         scmdbuf = scmdbuf + " WHERE ([EspectaculoId] >= @AV6cEspectaculoId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cEspectaculoNombre)) )
         {
            sWhereString = sWhereString + " and ([EspectaculoNombre] like @lV7cEspectaculoNombre)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (DateTime.MinValue==AV8cEspectaculoFecha) )
         {
            sWhereString = sWhereString + " and ([EspectaculoFecha] >= @AV8cEspectaculoFecha)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV10cEspectaculoPaisId) )
         {
            sWhereString = sWhereString + " and ([EspectaculoPaisId] >= @AV10cEspectaculoPaisId)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (0==AV11cEspectaculoCiudadId) )
         {
            sWhereString = sWhereString + " and ([EspectaculoCiudadId] >= @AV11cEspectaculoCiudadId)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV12cLugarId) )
         {
            sWhereString = sWhereString + " and ([LugarId] >= @AV12cLugarId)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV15cLugarPaisId) )
         {
            sWhereString = sWhereString + " and ([LugarPaisId] >= @AV15cLugarPaisId)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         scmdbuf = scmdbuf + "";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00092(context, (String)dynConstraints[0] , (DateTime)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
               case 1 :
                     return conditional_H00093(context, (String)dynConstraints[0] , (DateTime)dynConstraints[1] , (short)dynConstraints[2] , (short)dynConstraints[3] , (short)dynConstraints[4] , (short)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] , (short)dynConstraints[11] , (short)dynConstraints[12] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

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
          Object[] prmH00092 ;
          prmH00092 = new Object[] {
          new Object[] {"@AV6cEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cEspectaculoNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@AV8cEspectaculoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10cEspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cEspectaculoCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cLugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15cLugarPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00093 ;
          prmH00093 = new Object[] {
          new Object[] {"@AV6cEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cEspectaculoNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@AV8cEspectaculoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10cEspectaculoPaisId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11cEspectaculoCiudadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12cLugarId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15cLugarPaisId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00092", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00092,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H00093", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00093,1, GxCacheFrequency.OFF ,false,false )
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getString(6, 100) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[9]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[12]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                return;
       }
    }

 }

}