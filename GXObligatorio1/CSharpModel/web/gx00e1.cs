/*
               File: Gx00E1
        Description: Selection List Localidad
             Author: GeneXus C# Generator version 16_0_7-138086
       Generated on: 2/25/2020 21:45:27.42
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
   public class gx00e1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00e1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public gx00e1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( short aP0_pEspectaculoId ,
                           out short aP1_pLocalidadId )
      {
         this.AV11pEspectaculoId = aP0_pEspectaculoId;
         this.AV12pLocalidadId = 0 ;
         executePrivate();
         aP1_pLocalidadId=this.AV12pLocalidadId;
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
               nRC_GXsfl_64 = (int)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_64_idx = (int)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_64_idx = GetNextPar( );
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
               AV6cLocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV7cLocalidadNombre = GetNextPar( );
               AV8cLocalidadCapacidad = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV9cLocalidadPrecio = NumberUtil.Val( GetNextPar( ), ".");
               AV10cLocalidadesVendidas = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV11pEspectaculoId = (short)(NumberUtil.Val( GetNextPar( ), "."));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid1_refresh( subGrid1_Rows, AV6cLocalidadId, AV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, AV11pEspectaculoId) ;
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
               AV11pEspectaculoId = (short)(NumberUtil.Val( gxfirstwebparm, "."));
               AssignAttri("", false, "AV11pEspectaculoId", StringUtil.LTrimStr( (decimal)(AV11pEspectaculoId), 4, 0));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12pLocalidadId = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AssignAttri("", false, "AV12pLocalidadId", StringUtil.LTrimStr( (decimal)(AV12pLocalidadId), 4, 0));
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
         PA2G2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2G2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022521452749", false, true);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("gx00e1.aspx") + "?" + UrlEncode("" +AV11pEspectaculoId) + "," + UrlEncode("" +AV12pLocalidadId)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vCLOCALIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cLocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLOCALIDADNOMBRE", StringUtil.RTrim( AV7cLocalidadNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCLOCALIDADCAPACIDAD", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cLocalidadCapacidad), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLOCALIDADPRECIO", StringUtil.LTrim( StringUtil.NToC( AV9cLocalidadPrecio, 9, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLOCALIDADESVENDIDAS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cLocalidadesVendidas), 5, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_64", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_64), 8, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPESPECTACULOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pEspectaculoId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPLOCALIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pLocalidadId), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ADVANCEDCONTAINER_Class", StringUtil.RTrim( divAdvancedcontainer_Class));
         GxWebStd.gx_hidden_field( context, "BTNTOGGLE_Class", StringUtil.RTrim( bttBtntoggle_Class));
         GxWebStd.gx_hidden_field( context, "LOCALIDADIDFILTERCONTAINER_Class", StringUtil.RTrim( divLocalidadidfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LOCALIDADNOMBREFILTERCONTAINER_Class", StringUtil.RTrim( divLocalidadnombrefiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LOCALIDADCAPACIDADFILTERCONTAINER_Class", StringUtil.RTrim( divLocalidadcapacidadfiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LOCALIDADPRECIOFILTERCONTAINER_Class", StringUtil.RTrim( divLocalidadpreciofiltercontainer_Class));
         GxWebStd.gx_hidden_field( context, "LOCALIDADESVENDIDASFILTERCONTAINER_Class", StringUtil.RTrim( divLocalidadesvendidasfiltercontainer_Class));
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
            WE2G2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2G2( ) ;
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
         return formatLink("gx00e1.aspx") + "?" + UrlEncode("" +AV11pEspectaculoId) + "," + UrlEncode("" +AV12pLocalidadId) ;
      }

      public override String GetPgmname( )
      {
         return "Gx00E1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Localidad" ;
      }

      protected void WB2G0( )
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
            GxWebStd.gx_div_start( context, divLocalidadidfiltercontainer_Internalname, 1, 0, "px", 0, "px", divLocalidadidfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllocalidadidfilter_Internalname, "Localidad Id", "", "", lblLbllocalidadidfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e112g1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClocalidadid_Internalname, "Localidad Id", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClocalidadid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cLocalidadId), 4, 0, ".", "")), ((edtavClocalidadid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cLocalidadId), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cLocalidadId), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,16);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClocalidadid_Jsonclick, 0, "Attribute", "", "", "", "", edtavClocalidadid_Visible, edtavClocalidadid_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx00E1.htm");
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
            GxWebStd.gx_div_start( context, divLocalidadnombrefiltercontainer_Internalname, 1, 0, "px", 0, "px", divLocalidadnombrefiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllocalidadnombrefilter_Internalname, "Localidad Nombre", "", "", lblLbllocalidadnombrefilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e122g1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClocalidadnombre_Internalname, "Localidad Nombre", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClocalidadnombre_Internalname, StringUtil.RTrim( AV7cLocalidadNombre), StringUtil.RTrim( context.localUtil.Format( AV7cLocalidadNombre, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClocalidadnombre_Jsonclick, 0, "Attribute", "", "", "", "", edtavClocalidadnombre_Visible, edtavClocalidadnombre_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "", "HLP_Gx00E1.htm");
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
            GxWebStd.gx_div_start( context, divLocalidadcapacidadfiltercontainer_Internalname, 1, 0, "px", 0, "px", divLocalidadcapacidadfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllocalidadcapacidadfilter_Internalname, "Localidad Capacidad", "", "", lblLbllocalidadcapacidadfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e132g1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClocalidadcapacidad_Internalname, "Localidad Capacidad", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClocalidadcapacidad_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cLocalidadCapacidad), 5, 0, ".", "")), ((edtavClocalidadcapacidad_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cLocalidadCapacidad), "ZZZZ9")) : context.localUtil.Format( (decimal)(AV8cLocalidadCapacidad), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,36);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClocalidadcapacidad_Jsonclick, 0, "Attribute", "", "", "", "", edtavClocalidadcapacidad_Visible, edtavClocalidadcapacidad_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx00E1.htm");
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
            GxWebStd.gx_div_start( context, divLocalidadpreciofiltercontainer_Internalname, 1, 0, "px", 0, "px", divLocalidadpreciofiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllocalidadpreciofilter_Internalname, "Localidad Precio", "", "", lblLbllocalidadpreciofilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e142g1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClocalidadprecio_Internalname, "Localidad Precio", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClocalidadprecio_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cLocalidadPrecio, 9, 2, ".", "")), ((edtavClocalidadprecio_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cLocalidadPrecio, "ZZZZZ9.99")) : context.localUtil.Format( AV9cLocalidadPrecio, "ZZZZZ9.99")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClocalidadprecio_Jsonclick, 0, "Attribute", "", "", "", "", edtavClocalidadprecio_Visible, edtavClocalidadprecio_Enabled, 0, "text", "", 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx00E1.htm");
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
            GxWebStd.gx_div_start( context, divLocalidadesvendidasfiltercontainer_Internalname, 1, 0, "px", 0, "px", divLocalidadesvendidasfiltercontainer_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblLbllocalidadesvendidasfilter_Internalname, "Localidades Vendidas", "", "", lblLbllocalidadesvendidasfilter_Jsonclick, "'"+""+"'"+",false,"+"'"+"e152g1_client"+"'", "", "WWAdvancedLabel WWFilterLabel", 7, "", 1, 1, 1, "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavClocalidadesvendidas_Internalname, "Localidades Vendidas", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_64_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavClocalidadesvendidas_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cLocalidadesVendidas), 5, 0, ".", "")), ((edtavClocalidadesvendidas_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cLocalidadesVendidas), "ZZZZ9")) : context.localUtil.Format( (decimal)(AV10cLocalidadesVendidas), "ZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavClocalidadesvendidas_Jsonclick, 0, "Attribute", "", "", "", "", edtavClocalidadesvendidas_Visible, edtavClocalidadesvendidas_Enabled, 0, "number", "1", 5, "chr", 1, "row", 5, 0, 0, 0, 1, -1, 0, true, "", "right", false, "", "HLP_Gx00E1.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            ClassString = bttBtntoggle_Class;
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntoggle_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "|||", bttBtntoggle_Jsonclick, 7, "|||", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e162g1_client"+"'", TempTags, "", 2, "HLP_Gx00E1.htm");
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" data-gxgridid=\"64\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Espectaculo Id") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A12LocalidadNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtLocalidadNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( ));
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")));
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
         if ( wbEnd == 64 )
         {
            wbEnd = 0;
            nRC_GXsfl_64 = (int)(nGXsfl_64_idx-1);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            ClassString = "BtnCancel";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(64), 2, 0)+","+"null"+");", "Cancel", bttBtn_cancel_Jsonclick, 1, "Cancel", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_Gx00E1.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 64 )
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

      protected void START2G2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_7-138086", 0) ;
            Form.Meta.addItem("description", "Selection List Localidad", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2G0( ) ;
      }

      protected void WS2G2( )
      {
         START2G2( ) ;
         EVT2G2( ) ;
      }

      protected void EVT2G2( )
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
                              nGXsfl_64_idx = (int)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
                              SubsflControlProps_642( ) ;
                              AV5LinkSelection = cgiGet( edtavLinkselection_Internalname);
                              AssignProp("", false, edtavLinkselection_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.convertURL( context.PathToRelativeUrl( AV5LinkSelection))), !bGXsfl_64_Refreshing);
                              AssignProp("", false, edtavLinkselection_Internalname, "SrcSet", context.GetImageSrcSet( AV5LinkSelection), true);
                              A11LocalidadId = (short)(context.localUtil.CToN( cgiGet( edtLocalidadId_Internalname), ".", ","));
                              A12LocalidadNombre = cgiGet( edtLocalidadNombre_Internalname);
                              A34EspectaculoId = (short)(context.localUtil.CToN( cgiGet( edtEspectaculoId_Internalname), ".", ","));
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E172G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Load */
                                    E182G2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Clocalidadid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADID"), ".", ",") != Convert.ToDecimal( AV6cLocalidadId )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clocalidadnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCLOCALIDADNOMBRE"), AV7cLocalidadNombre) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clocalidadcapacidad Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADCAPACIDAD"), ".", ",") != Convert.ToDecimal( AV8cLocalidadCapacidad )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clocalidadprecio Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADPRECIO"), ".", ",") != AV9cLocalidadPrecio )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Clocalidadesvendidas Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADESVENDIDAS"), ".", ",") != Convert.ToDecimal( AV10cLocalidadesVendidas )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: Enter */
                                          E192G2 ();
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

      protected void WE2G2( )
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

      protected void PA2G2( )
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
         SubsflControlProps_642( ) ;
         while ( nGXsfl_64_idx <= nRC_GXsfl_64 )
         {
            sendrow_642( ) ;
            nGXsfl_64_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1);
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
            SubsflControlProps_642( ) ;
         }
         AddString( context.httpAjaxContext.getJSONContainerResponse( Grid1Container)) ;
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int subGrid1_Rows ,
                                        short AV6cLocalidadId ,
                                        String AV7cLocalidadNombre ,
                                        int AV8cLocalidadCapacidad ,
                                        decimal AV9cLocalidadPrecio ,
                                        int AV10cLocalidadesVendidas ,
                                        short AV11pEspectaculoId )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GRID1_nCurrentRecord = 0;
         RF2G2( ) ;
         /* End function gxgrGrid1_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_LOCALIDADID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "LOCALIDADID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")));
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
         RF2G2( ) ;
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

      protected void RF2G2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            Grid1Container.ClearRows();
         }
         wbStart = 64;
         nGXsfl_64_idx = 1;
         sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
         SubsflControlProps_642( ) ;
         bGXsfl_64_Refreshing = true;
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
            SubsflControlProps_642( ) ;
            GXPagingFrom2 = (int)(GRID1_nFirstRecordOnPage);
            GXPagingTo2 = (int)(subGrid1_fnc_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV7cLocalidadNombre ,
                                                 AV8cLocalidadCapacidad ,
                                                 AV9cLocalidadPrecio ,
                                                 AV10cLocalidadesVendidas ,
                                                 A12LocalidadNombre ,
                                                 A13LocalidadCapacidad ,
                                                 A14LocalidadPrecio ,
                                                 A15LocalidadesVendidas ,
                                                 AV11pEspectaculoId ,
                                                 AV6cLocalidadId ,
                                                 A34EspectaculoId } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT,
                                                 TypeConstants.SHORT
                                                 }
            } ) ;
            lV7cLocalidadNombre = StringUtil.PadR( StringUtil.RTrim( AV7cLocalidadNombre), 100, "%");
            /* Using cursor H002G2 */
            pr_default.execute(0, new Object[] {AV11pEspectaculoId, AV6cLocalidadId, lV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_64_idx = 1;
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
            SubsflControlProps_642( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( GRID1_nCurrentRecord < subGrid1_fnc_Recordsperpage( ) ) ) )
            {
               A15LocalidadesVendidas = H002G2_A15LocalidadesVendidas[0];
               A14LocalidadPrecio = H002G2_A14LocalidadPrecio[0];
               A13LocalidadCapacidad = H002G2_A13LocalidadCapacidad[0];
               A34EspectaculoId = H002G2_A34EspectaculoId[0];
               A12LocalidadNombre = H002G2_A12LocalidadNombre[0];
               A11LocalidadId = H002G2_A11LocalidadId[0];
               /* Execute user event: Load */
               E182G2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 64;
            WB2G0( ) ;
         }
         bGXsfl_64_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2G2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_LOCALIDADID"+"_"+sGXsfl_64_idx, GetSecureSignedToken( sGXsfl_64_idx, context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9"), context));
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
                                              AV7cLocalidadNombre ,
                                              AV8cLocalidadCapacidad ,
                                              AV9cLocalidadPrecio ,
                                              AV10cLocalidadesVendidas ,
                                              A12LocalidadNombre ,
                                              A13LocalidadCapacidad ,
                                              A14LocalidadPrecio ,
                                              A15LocalidadesVendidas ,
                                              AV11pEspectaculoId ,
                                              AV6cLocalidadId ,
                                              A34EspectaculoId } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.STRING, TypeConstants.INT, TypeConstants.DECIMAL, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT,
                                              TypeConstants.SHORT
                                              }
         } ) ;
         lV7cLocalidadNombre = StringUtil.PadR( StringUtil.RTrim( AV7cLocalidadNombre), 100, "%");
         /* Using cursor H002G3 */
         pr_default.execute(1, new Object[] {AV11pEspectaculoId, AV6cLocalidadId, lV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas});
         GRID1_nRecordCount = H002G3_AGRID1_nRecordCount[0];
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cLocalidadId, AV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, AV11pEspectaculoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cLocalidadId, AV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, AV11pEspectaculoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cLocalidadId, AV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, AV11pEspectaculoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cLocalidadId, AV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, AV11pEspectaculoId) ;
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
            gxgrGrid1_refresh( subGrid1_Rows, AV6cLocalidadId, AV7cLocalidadNombre, AV8cLocalidadCapacidad, AV9cLocalidadPrecio, AV10cLocalidadesVendidas, AV11pEspectaculoId) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP2G0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E172G2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read saved values. */
            nRC_GXsfl_64 = (int)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_64"), ".", ","));
            GRID1_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ","));
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ","));
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClocalidadid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClocalidadid_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLOCALIDADID");
               GX_FocusControl = edtavClocalidadid_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV6cLocalidadId = 0;
               AssignAttri("", false, "AV6cLocalidadId", StringUtil.LTrimStr( (decimal)(AV6cLocalidadId), 4, 0));
            }
            else
            {
               AV6cLocalidadId = (short)(context.localUtil.CToN( cgiGet( edtavClocalidadid_Internalname), ".", ","));
               AssignAttri("", false, "AV6cLocalidadId", StringUtil.LTrimStr( (decimal)(AV6cLocalidadId), 4, 0));
            }
            AV7cLocalidadNombre = cgiGet( edtavClocalidadnombre_Internalname);
            AssignAttri("", false, "AV7cLocalidadNombre", AV7cLocalidadNombre);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClocalidadcapacidad_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClocalidadcapacidad_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLOCALIDADCAPACIDAD");
               GX_FocusControl = edtavClocalidadcapacidad_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV8cLocalidadCapacidad = 0;
               AssignAttri("", false, "AV8cLocalidadCapacidad", StringUtil.LTrimStr( (decimal)(AV8cLocalidadCapacidad), 5, 0));
            }
            else
            {
               AV8cLocalidadCapacidad = (int)(context.localUtil.CToN( cgiGet( edtavClocalidadcapacidad_Internalname), ".", ","));
               AssignAttri("", false, "AV8cLocalidadCapacidad", StringUtil.LTrimStr( (decimal)(AV8cLocalidadCapacidad), 5, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClocalidadprecio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClocalidadprecio_Internalname), ".", ",") > 999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLOCALIDADPRECIO");
               GX_FocusControl = edtavClocalidadprecio_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV9cLocalidadPrecio = 0;
               AssignAttri("", false, "AV9cLocalidadPrecio", StringUtil.LTrimStr( AV9cLocalidadPrecio, 9, 2));
            }
            else
            {
               AV9cLocalidadPrecio = context.localUtil.CToN( cgiGet( edtavClocalidadprecio_Internalname), ".", ",");
               AssignAttri("", false, "AV9cLocalidadPrecio", StringUtil.LTrimStr( AV9cLocalidadPrecio, 9, 2));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClocalidadesvendidas_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClocalidadesvendidas_Internalname), ".", ",") > Convert.ToDecimal( 99999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCLOCALIDADESVENDIDAS");
               GX_FocusControl = edtavClocalidadesvendidas_Internalname;
               AssignAttri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10cLocalidadesVendidas = 0;
               AssignAttri("", false, "AV10cLocalidadesVendidas", StringUtil.LTrimStr( (decimal)(AV10cLocalidadesVendidas), 5, 0));
            }
            else
            {
               AV10cLocalidadesVendidas = (int)(context.localUtil.CToN( cgiGet( edtavClocalidadesvendidas_Internalname), ".", ","));
               AssignAttri("", false, "AV10cLocalidadesVendidas", StringUtil.LTrimStr( (decimal)(AV10cLocalidadesVendidas), 5, 0));
            }
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADID"), ".", ",") != Convert.ToDecimal( AV6cLocalidadId )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vCLOCALIDADNOMBRE"), AV7cLocalidadNombre) != 0 )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADCAPACIDAD"), ".", ",") != Convert.ToDecimal( AV8cLocalidadCapacidad )) )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADPRECIO"), ".", ",") != AV9cLocalidadPrecio )
            {
               GRID1_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLOCALIDADESVENDIDAS"), ".", ",") != Convert.ToDecimal( AV10cLocalidadesVendidas )) )
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
         E172G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E172G2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Selection List %1", "Localidad", "", "", "", "", "", "", "", "");
         AssignProp("", false, "FORM", "Caption", Form.Caption, true);
         AV13ADVANCED_LABEL_TEMPLATE = "%1 <strong>%2</strong>";
      }

      private void E182G2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         AssignAttri("", false, edtavLinkselection_Internalname, AV5LinkSelection);
         AV16Linkselection_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         sendrow_642( ) ;
         GRID1_nCurrentRecord = (long)(GRID1_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_64_Refreshing )
         {
            context.DoAjaxLoad(64, Grid1Row);
         }
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E192G2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E192G2( )
      {
         /* Enter Routine */
         AV12pLocalidadId = A11LocalidadId;
         AssignAttri("", false, "AV12pLocalidadId", StringUtil.LTrimStr( (decimal)(AV12pLocalidadId), 4, 0));
         context.setWebReturnParms(new Object[] {(short)AV12pLocalidadId});
         context.setWebReturnParmsMetadata(new Object[] {"AV12pLocalidadId"});
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
         AV11pEspectaculoId = Convert.ToInt16(getParm(obj,0));
         AssignAttri("", false, "AV11pEspectaculoId", StringUtil.LTrimStr( (decimal)(AV11pEspectaculoId), 4, 0));
         AV12pLocalidadId = Convert.ToInt16(getParm(obj,1));
         AssignAttri("", false, "AV12pLocalidadId", StringUtil.LTrimStr( (decimal)(AV12pLocalidadId), 4, 0));
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
         PA2G2( ) ;
         WS2G2( ) ;
         WE2G2( ) ;
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
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022521452811", true, true);
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
         context.AddJavascriptSource("gx00e1.js", "?202022521452811", false, true);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_idx;
         edtLocalidadId_Internalname = "LOCALIDADID_"+sGXsfl_64_idx;
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE_"+sGXsfl_64_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_64_idx;
      }

      protected void SubsflControlProps_fel_642( )
      {
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_64_fel_idx;
         edtLocalidadId_Internalname = "LOCALIDADID_"+sGXsfl_64_fel_idx;
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE_"+sGXsfl_64_fel_idx;
         edtEspectaculoId_Internalname = "ESPECTACULOID_"+sGXsfl_64_fel_idx;
      }

      protected void sendrow_642( )
      {
         SubsflControlProps_642( ) ;
         WB2G0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_64_idx <= subGrid1_fnc_Recordsperpage( ) * 1 ) )
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
               if ( ((int)((nGXsfl_64_idx) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_64_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link, !bGXsfl_64_Refreshing);
            ClassString = "SelectionAttribute";
            StyleString = "";
            AV5LinkSelection_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection))&&String.IsNullOrEmpty(StringUtil.RTrim( AV16Linkselection_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV5LinkSelection)) ? AV16Linkselection_GXI : context.PathToRelativeUrl( AV5LinkSelection));
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)sImgUrl,(String)edtavLinkselection_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)"",(short)1,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV5LinkSelection_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A11LocalidadId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtLocalidadId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "DescriptionAttribute";
            edtLocalidadNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A11LocalidadId), 4, 0, ".", "")))+"'"+"]);";
            AssignProp("", false, edtLocalidadNombre_Internalname, "Link", edtLocalidadNombre_Link, !bGXsfl_64_Refreshing);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLocalidadNombre_Internalname,StringUtil.RTrim( A12LocalidadNombre),(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtLocalidadNombre_Link,(String)"",(String)"",(String)"",(String)edtLocalidadNombre_Jsonclick,(short)0,(String)"DescriptionAttribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)-1,(bool)true,(String)"Nombre",(String)"left",(bool)true,(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEspectaculoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34EspectaculoId), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A34EspectaculoId), "ZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtEspectaculoId_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)64,(short)1,(short)-1,(short)0,(bool)true,(String)"Id",(String)"right",(bool)false,(String)""});
            send_integrity_lvl_hashes2G2( ) ;
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_64_idx = ((subGrid1_Islastpage==1)&&(nGXsfl_64_idx+1>subGrid1_fnc_Recordsperpage( )) ? 1 : nGXsfl_64_idx+1);
            sGXsfl_64_idx = StringUtil.PadL( StringUtil.LTrimStr( (decimal)(nGXsfl_64_idx), 4, 0), 4, "0");
            SubsflControlProps_642( ) ;
         }
         /* End function sendrow_642 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         lblLbllocalidadidfilter_Internalname = "LBLLOCALIDADIDFILTER";
         edtavClocalidadid_Internalname = "vCLOCALIDADID";
         divLocalidadidfiltercontainer_Internalname = "LOCALIDADIDFILTERCONTAINER";
         lblLbllocalidadnombrefilter_Internalname = "LBLLOCALIDADNOMBREFILTER";
         edtavClocalidadnombre_Internalname = "vCLOCALIDADNOMBRE";
         divLocalidadnombrefiltercontainer_Internalname = "LOCALIDADNOMBREFILTERCONTAINER";
         lblLbllocalidadcapacidadfilter_Internalname = "LBLLOCALIDADCAPACIDADFILTER";
         edtavClocalidadcapacidad_Internalname = "vCLOCALIDADCAPACIDAD";
         divLocalidadcapacidadfiltercontainer_Internalname = "LOCALIDADCAPACIDADFILTERCONTAINER";
         lblLbllocalidadpreciofilter_Internalname = "LBLLOCALIDADPRECIOFILTER";
         edtavClocalidadprecio_Internalname = "vCLOCALIDADPRECIO";
         divLocalidadpreciofiltercontainer_Internalname = "LOCALIDADPRECIOFILTERCONTAINER";
         lblLbllocalidadesvendidasfilter_Internalname = "LBLLOCALIDADESVENDIDASFILTER";
         edtavClocalidadesvendidas_Internalname = "vCLOCALIDADESVENDIDAS";
         divLocalidadesvendidasfiltercontainer_Internalname = "LOCALIDADESVENDIDASFILTERCONTAINER";
         divAdvancedcontainer_Internalname = "ADVANCEDCONTAINER";
         bttBtntoggle_Internalname = "BTNTOGGLE";
         edtavLinkselection_Internalname = "vLINKSELECTION";
         edtLocalidadId_Internalname = "LOCALIDADID";
         edtLocalidadNombre_Internalname = "LOCALIDADNOMBRE";
         edtEspectaculoId_Internalname = "ESPECTACULOID";
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
         edtEspectaculoId_Jsonclick = "";
         edtLocalidadNombre_Jsonclick = "";
         edtLocalidadId_Jsonclick = "";
         subGrid1_Allowcollapsing = 0;
         subGrid1_Allowselection = 0;
         edtLocalidadNombre_Link = "";
         edtavLinkselection_Link = "";
         subGrid1_Header = "";
         subGrid1_Class = "PromptGrid";
         subGrid1_Backcolorstyle = 0;
         edtavClocalidadesvendidas_Jsonclick = "";
         edtavClocalidadesvendidas_Enabled = 1;
         edtavClocalidadesvendidas_Visible = 1;
         edtavClocalidadprecio_Jsonclick = "";
         edtavClocalidadprecio_Enabled = 1;
         edtavClocalidadprecio_Visible = 1;
         edtavClocalidadcapacidad_Jsonclick = "";
         edtavClocalidadcapacidad_Enabled = 1;
         edtavClocalidadcapacidad_Visible = 1;
         edtavClocalidadnombre_Jsonclick = "";
         edtavClocalidadnombre_Enabled = 1;
         edtavClocalidadnombre_Visible = 1;
         edtavClocalidadid_Jsonclick = "";
         edtavClocalidadid_Enabled = 1;
         edtavClocalidadid_Visible = 1;
         divLocalidadesvendidasfiltercontainer_Class = "AdvancedContainerItem";
         divLocalidadpreciofiltercontainer_Class = "AdvancedContainerItem";
         divLocalidadcapacidadfiltercontainer_Class = "AdvancedContainerItem";
         divLocalidadnombrefiltercontainer_Class = "AdvancedContainerItem";
         divLocalidadidfiltercontainer_Class = "AdvancedContainerItem";
         bttBtntoggle_Class = "BtnToggle";
         divAdvancedcontainer_Class = "AdvancedContainerVisible";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Selection List Localidad";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV7cLocalidadNombre',fld:'vCLOCALIDADNOMBRE',pic:''},{av:'AV8cLocalidadCapacidad',fld:'vCLOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'AV9cLocalidadPrecio',fld:'vCLOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'AV10cLocalidadesVendidas',fld:'vCLOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'AV11pEspectaculoId',fld:'vPESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("'TOGGLE'","{handler:'E162G1',iparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]");
         setEventMetadata("'TOGGLE'",",oparms:[{av:'divAdvancedcontainer_Class',ctrl:'ADVANCEDCONTAINER',prop:'Class'},{ctrl:'BTNTOGGLE',prop:'Class'}]}");
         setEventMetadata("LBLLOCALIDADIDFILTER.CLICK","{handler:'E112G1',iparms:[{av:'divLocalidadidfiltercontainer_Class',ctrl:'LOCALIDADIDFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLOCALIDADIDFILTER.CLICK",",oparms:[{av:'divLocalidadidfiltercontainer_Class',ctrl:'LOCALIDADIDFILTERCONTAINER',prop:'Class'},{av:'edtavClocalidadid_Visible',ctrl:'vCLOCALIDADID',prop:'Visible'}]}");
         setEventMetadata("LBLLOCALIDADNOMBREFILTER.CLICK","{handler:'E122G1',iparms:[{av:'divLocalidadnombrefiltercontainer_Class',ctrl:'LOCALIDADNOMBREFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLOCALIDADNOMBREFILTER.CLICK",",oparms:[{av:'divLocalidadnombrefiltercontainer_Class',ctrl:'LOCALIDADNOMBREFILTERCONTAINER',prop:'Class'},{av:'edtavClocalidadnombre_Visible',ctrl:'vCLOCALIDADNOMBRE',prop:'Visible'}]}");
         setEventMetadata("LBLLOCALIDADCAPACIDADFILTER.CLICK","{handler:'E132G1',iparms:[{av:'divLocalidadcapacidadfiltercontainer_Class',ctrl:'LOCALIDADCAPACIDADFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLOCALIDADCAPACIDADFILTER.CLICK",",oparms:[{av:'divLocalidadcapacidadfiltercontainer_Class',ctrl:'LOCALIDADCAPACIDADFILTERCONTAINER',prop:'Class'},{av:'edtavClocalidadcapacidad_Visible',ctrl:'vCLOCALIDADCAPACIDAD',prop:'Visible'}]}");
         setEventMetadata("LBLLOCALIDADPRECIOFILTER.CLICK","{handler:'E142G1',iparms:[{av:'divLocalidadpreciofiltercontainer_Class',ctrl:'LOCALIDADPRECIOFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLOCALIDADPRECIOFILTER.CLICK",",oparms:[{av:'divLocalidadpreciofiltercontainer_Class',ctrl:'LOCALIDADPRECIOFILTERCONTAINER',prop:'Class'},{av:'edtavClocalidadprecio_Visible',ctrl:'vCLOCALIDADPRECIO',prop:'Visible'}]}");
         setEventMetadata("LBLLOCALIDADESVENDIDASFILTER.CLICK","{handler:'E152G1',iparms:[{av:'divLocalidadesvendidasfiltercontainer_Class',ctrl:'LOCALIDADESVENDIDASFILTERCONTAINER',prop:'Class'}]");
         setEventMetadata("LBLLOCALIDADESVENDIDASFILTER.CLICK",",oparms:[{av:'divLocalidadesvendidasfiltercontainer_Class',ctrl:'LOCALIDADESVENDIDASFILTERCONTAINER',prop:'Class'},{av:'edtavClocalidadesvendidas_Visible',ctrl:'vCLOCALIDADESVENDIDAS',prop:'Visible'}]}");
         setEventMetadata("ENTER","{handler:'E192G2',iparms:[{av:'A11LocalidadId',fld:'LOCALIDADID',pic:'ZZZ9',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV12pLocalidadId',fld:'vPLOCALIDADID',pic:'ZZZ9'}]}");
         setEventMetadata("GRID1_FIRSTPAGE","{handler:'subgrid1_firstpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV7cLocalidadNombre',fld:'vCLOCALIDADNOMBRE',pic:''},{av:'AV8cLocalidadCapacidad',fld:'vCLOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'AV9cLocalidadPrecio',fld:'vCLOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'AV10cLocalidadesVendidas',fld:'vCLOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'AV11pEspectaculoId',fld:'vPESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_FIRSTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_PREVPAGE","{handler:'subgrid1_previouspage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV7cLocalidadNombre',fld:'vCLOCALIDADNOMBRE',pic:''},{av:'AV8cLocalidadCapacidad',fld:'vCLOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'AV9cLocalidadPrecio',fld:'vCLOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'AV10cLocalidadesVendidas',fld:'vCLOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'AV11pEspectaculoId',fld:'vPESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_PREVPAGE",",oparms:[]}");
         setEventMetadata("GRID1_NEXTPAGE","{handler:'subgrid1_nextpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV7cLocalidadNombre',fld:'vCLOCALIDADNOMBRE',pic:''},{av:'AV8cLocalidadCapacidad',fld:'vCLOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'AV9cLocalidadPrecio',fld:'vCLOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'AV10cLocalidadesVendidas',fld:'vCLOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'AV11pEspectaculoId',fld:'vPESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_NEXTPAGE",",oparms:[]}");
         setEventMetadata("GRID1_LASTPAGE","{handler:'subgrid1_lastpage',iparms:[{av:'GRID1_nFirstRecordOnPage'},{av:'GRID1_nEOF'},{av:'subGrid1_Rows',ctrl:'GRID1',prop:'Rows'},{av:'AV6cLocalidadId',fld:'vCLOCALIDADID',pic:'ZZZ9'},{av:'AV7cLocalidadNombre',fld:'vCLOCALIDADNOMBRE',pic:''},{av:'AV8cLocalidadCapacidad',fld:'vCLOCALIDADCAPACIDAD',pic:'ZZZZ9'},{av:'AV9cLocalidadPrecio',fld:'vCLOCALIDADPRECIO',pic:'ZZZZZ9.99'},{av:'AV10cLocalidadesVendidas',fld:'vCLOCALIDADESVENDIDAS',pic:'ZZZZ9'},{av:'AV11pEspectaculoId',fld:'vPESPECTACULOID',pic:'ZZZ9'}]");
         setEventMetadata("GRID1_LASTPAGE",",oparms:[]}");
         setEventMetadata("NULL","{handler:'Valid_Espectaculoid',iparms:[]");
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
         AV7cLocalidadNombre = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         lblLbllocalidadidfilter_Jsonclick = "";
         TempTags = "";
         lblLbllocalidadnombrefilter_Jsonclick = "";
         lblLbllocalidadcapacidadfilter_Jsonclick = "";
         lblLbllocalidadpreciofilter_Jsonclick = "";
         lblLbllocalidadesvendidasfilter_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         bttBtntoggle_Jsonclick = "";
         Grid1Container = new GXWebGrid( context);
         sStyleString = "";
         subGrid1_Linesclass = "";
         Grid1Column = new GXWebColumn();
         AV5LinkSelection = "";
         A12LocalidadNombre = "";
         bttBtn_cancel_Jsonclick = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV16Linkselection_GXI = "";
         scmdbuf = "";
         lV7cLocalidadNombre = "";
         H002G2_A15LocalidadesVendidas = new int[1] ;
         H002G2_A14LocalidadPrecio = new decimal[1] ;
         H002G2_A13LocalidadCapacidad = new int[1] ;
         H002G2_A34EspectaculoId = new short[1] ;
         H002G2_A12LocalidadNombre = new String[] {""} ;
         H002G2_A11LocalidadId = new short[1] ;
         H002G3_AGRID1_nRecordCount = new long[1] ;
         AV13ADVANCED_LABEL_TEMPLATE = "";
         Grid1Row = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00e1__default(),
            new Object[][] {
                new Object[] {
               H002G2_A15LocalidadesVendidas, H002G2_A14LocalidadPrecio, H002G2_A13LocalidadCapacidad, H002G2_A34EspectaculoId, H002G2_A12LocalidadNombre, H002G2_A11LocalidadId
               }
               , new Object[] {
               H002G3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private short AV11pEspectaculoId ;
      private short wcpOAV11pEspectaculoId ;
      private short nGotPars ;
      private short GxWebError ;
      private short GRID1_nEOF ;
      private short AV6cLocalidadId ;
      private short AV12pLocalidadId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short A11LocalidadId ;
      private short A34EspectaculoId ;
      private short subGrid1_Allowselection ;
      private short subGrid1_Allowhovering ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int nRC_GXsfl_64 ;
      private int nGXsfl_64_idx=1 ;
      private int subGrid1_Rows ;
      private int AV8cLocalidadCapacidad ;
      private int AV10cLocalidadesVendidas ;
      private int edtavClocalidadid_Enabled ;
      private int edtavClocalidadid_Visible ;
      private int edtavClocalidadnombre_Visible ;
      private int edtavClocalidadnombre_Enabled ;
      private int edtavClocalidadcapacidad_Enabled ;
      private int edtavClocalidadcapacidad_Visible ;
      private int edtavClocalidadprecio_Enabled ;
      private int edtavClocalidadprecio_Visible ;
      private int edtavClocalidadesvendidas_Enabled ;
      private int edtavClocalidadesvendidas_Visible ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectedindex ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int subGrid1_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int A13LocalidadCapacidad ;
      private int A15LocalidadesVendidas ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private long GRID1_nFirstRecordOnPage ;
      private long GRID1_nCurrentRecord ;
      private long GRID1_nRecordCount ;
      private decimal AV9cLocalidadPrecio ;
      private decimal A14LocalidadPrecio ;
      private String divAdvancedcontainer_Class ;
      private String bttBtntoggle_Class ;
      private String divLocalidadidfiltercontainer_Class ;
      private String divLocalidadnombrefiltercontainer_Class ;
      private String divLocalidadcapacidadfiltercontainer_Class ;
      private String divLocalidadpreciofiltercontainer_Class ;
      private String divLocalidadesvendidasfiltercontainer_Class ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_64_idx="0001" ;
      private String AV7cLocalidadNombre ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divMain_Internalname ;
      private String divAdvancedcontainer_Internalname ;
      private String divLocalidadidfiltercontainer_Internalname ;
      private String lblLbllocalidadidfilter_Internalname ;
      private String lblLbllocalidadidfilter_Jsonclick ;
      private String edtavClocalidadid_Internalname ;
      private String TempTags ;
      private String edtavClocalidadid_Jsonclick ;
      private String divLocalidadnombrefiltercontainer_Internalname ;
      private String lblLbllocalidadnombrefilter_Internalname ;
      private String lblLbllocalidadnombrefilter_Jsonclick ;
      private String edtavClocalidadnombre_Internalname ;
      private String edtavClocalidadnombre_Jsonclick ;
      private String divLocalidadcapacidadfiltercontainer_Internalname ;
      private String lblLbllocalidadcapacidadfilter_Internalname ;
      private String lblLbllocalidadcapacidadfilter_Jsonclick ;
      private String edtavClocalidadcapacidad_Internalname ;
      private String edtavClocalidadcapacidad_Jsonclick ;
      private String divLocalidadpreciofiltercontainer_Internalname ;
      private String lblLbllocalidadpreciofilter_Internalname ;
      private String lblLbllocalidadpreciofilter_Jsonclick ;
      private String edtavClocalidadprecio_Internalname ;
      private String edtavClocalidadprecio_Jsonclick ;
      private String divLocalidadesvendidasfiltercontainer_Internalname ;
      private String lblLbllocalidadesvendidasfilter_Internalname ;
      private String lblLbllocalidadesvendidasfilter_Jsonclick ;
      private String edtavClocalidadesvendidas_Internalname ;
      private String edtavClocalidadesvendidas_Jsonclick ;
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
      private String A12LocalidadNombre ;
      private String edtLocalidadNombre_Link ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtLocalidadId_Internalname ;
      private String edtLocalidadNombre_Internalname ;
      private String edtEspectaculoId_Internalname ;
      private String scmdbuf ;
      private String lV7cLocalidadNombre ;
      private String AV13ADVANCED_LABEL_TEMPLATE ;
      private String sGXsfl_64_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtLocalidadId_Jsonclick ;
      private String edtLocalidadNombre_Jsonclick ;
      private String edtEspectaculoId_Jsonclick ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_64_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5LinkSelection_IsBlob ;
      private String AV16Linkselection_GXI ;
      private String AV5LinkSelection ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] H002G2_A15LocalidadesVendidas ;
      private decimal[] H002G2_A14LocalidadPrecio ;
      private int[] H002G2_A13LocalidadCapacidad ;
      private short[] H002G2_A34EspectaculoId ;
      private String[] H002G2_A12LocalidadNombre ;
      private short[] H002G2_A11LocalidadId ;
      private long[] H002G3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP1_pLocalidadId ;
      private GXWebForm Form ;
   }

   public class gx00e1__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002G2( IGxContext context ,
                                             String AV7cLocalidadNombre ,
                                             int AV8cLocalidadCapacidad ,
                                             decimal AV9cLocalidadPrecio ,
                                             int AV10cLocalidadesVendidas ,
                                             String A12LocalidadNombre ,
                                             int A13LocalidadCapacidad ,
                                             decimal A14LocalidadPrecio ,
                                             int A15LocalidadesVendidas ,
                                             short AV11pEspectaculoId ,
                                             short AV6cLocalidadId ,
                                             short A34EspectaculoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int1 ;
         GXv_int1 = new short [9] ;
         Object[] GXv_Object2 ;
         GXv_Object2 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [LocalidadesVendidas], [LocalidadPrecio], [LocalidadCapacidad], [EspectaculoId], [LocalidadNombre], [LocalidadId]";
         sFromString = " FROM [EspectaculoLocalidad]";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([EspectaculoId] = @AV11pEspectaculoId and [LocalidadId] >= @AV6cLocalidadId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cLocalidadNombre)) )
         {
            sWhereString = sWhereString + " and ([LocalidadNombre] like @lV7cLocalidadNombre)";
         }
         else
         {
            GXv_int1[2] = 1;
         }
         if ( ! (0==AV8cLocalidadCapacidad) )
         {
            sWhereString = sWhereString + " and ([LocalidadCapacidad] >= @AV8cLocalidadCapacidad)";
         }
         else
         {
            GXv_int1[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cLocalidadPrecio) )
         {
            sWhereString = sWhereString + " and ([LocalidadPrecio] >= @AV9cLocalidadPrecio)";
         }
         else
         {
            GXv_int1[4] = 1;
         }
         if ( ! (0==AV10cLocalidadesVendidas) )
         {
            sWhereString = sWhereString + " and ([LocalidadesVendidas] >= @AV10cLocalidadesVendidas)";
         }
         else
         {
            GXv_int1[5] = 1;
         }
         sOrderString = sOrderString + " ORDER BY [EspectaculoId], [LocalidadId]";
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + sOrderString + "" + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object2[0] = scmdbuf;
         GXv_Object2[1] = GXv_int1;
         return GXv_Object2 ;
      }

      protected Object[] conditional_H002G3( IGxContext context ,
                                             String AV7cLocalidadNombre ,
                                             int AV8cLocalidadCapacidad ,
                                             decimal AV9cLocalidadPrecio ,
                                             int AV10cLocalidadesVendidas ,
                                             String A12LocalidadNombre ,
                                             int A13LocalidadCapacidad ,
                                             decimal A14LocalidadPrecio ,
                                             int A15LocalidadesVendidas ,
                                             short AV11pEspectaculoId ,
                                             short AV6cLocalidadId ,
                                             short A34EspectaculoId )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [EspectaculoLocalidad]";
         scmdbuf = scmdbuf + " WHERE ([EspectaculoId] = @AV11pEspectaculoId and [LocalidadId] >= @AV6cLocalidadId)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV7cLocalidadNombre)) )
         {
            sWhereString = sWhereString + " and ([LocalidadNombre] like @lV7cLocalidadNombre)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV8cLocalidadCapacidad) )
         {
            sWhereString = sWhereString + " and ([LocalidadCapacidad] >= @AV8cLocalidadCapacidad)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV9cLocalidadPrecio) )
         {
            sWhereString = sWhereString + " and ([LocalidadPrecio] >= @AV9cLocalidadPrecio)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (0==AV10cLocalidadesVendidas) )
         {
            sWhereString = sWhereString + " and ([LocalidadesVendidas] >= @AV10cLocalidadesVendidas)";
         }
         else
         {
            GXv_int3[5] = 1;
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
                     return conditional_H002G2(context, (String)dynConstraints[0] , (int)dynConstraints[1] , (decimal)dynConstraints[2] , (int)dynConstraints[3] , (String)dynConstraints[4] , (int)dynConstraints[5] , (decimal)dynConstraints[6] , (int)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
               case 1 :
                     return conditional_H002G3(context, (String)dynConstraints[0] , (int)dynConstraints[1] , (decimal)dynConstraints[2] , (int)dynConstraints[3] , (String)dynConstraints[4] , (int)dynConstraints[5] , (decimal)dynConstraints[6] , (int)dynConstraints[7] , (short)dynConstraints[8] , (short)dynConstraints[9] , (short)dynConstraints[10] );
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
          Object[] prmH002G2 ;
          prmH002G2 = new Object[] {
          new Object[] {"@AV11pEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cLocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cLocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@AV8cLocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@AV9cLocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV10cLocalidadesVendidas",SqlDbType.Int,5,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002G3 ;
          prmH002G3 = new Object[] {
          new Object[] {"@AV11pEspectaculoId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cLocalidadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cLocalidadNombre",SqlDbType.NChar,100,0} ,
          new Object[] {"@AV8cLocalidadCapacidad",SqlDbType.Int,5,0} ,
          new Object[] {"@AV9cLocalidadPrecio",SqlDbType.Decimal,9,2} ,
          new Object[] {"@AV10cLocalidadesVendidas",SqlDbType.Int,5,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002G2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002G2,11, GxCacheFrequency.OFF ,false,false )
             ,new CursorDef("H002G3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002G3,1, GxCacheFrequency.OFF ,false,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 100) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
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
                   stmt.SetParameter(sIdx, (short)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[17]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                return;
       }
    }

 }

}
