/*!   GeneXus C# 16_0_7-138086 on 2/17/2020 21:44:24.36
*/
gx.evt.autoSkip=!1;gx.define("gx0010",!1,function(){var n,t;this.ServerClass="gx0010";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.anyGridBaseTable=!0;this.hasEnterEvent=!0;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV8pPaisId=gx.fn.getIntegerValue("vPPAISID",",")};this.e13071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")=="AdvancedContainer"?(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer AdvancedContainerVisible"),gx.fn.setCtrlProperty("BTNTOGGLE","Class",gx.fn.getCtrlProperty("BTNTOGGLE","Class")+" BtnToggleActive")):(gx.fn.setCtrlProperty("ADVANCEDCONTAINER","Class","AdvancedContainer"),gx.fn.setCtrlProperty("BTNTOGGLE","Class","BtnToggle")),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]),gx.$.Deferred().resolve()};this.e11071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PAISIDFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PAISIDFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPAISID","Visible",!0)):(gx.fn.setCtrlProperty("PAISIDFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPAISID","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PAISIDFILTERCONTAINER","Class")',ctrl:"PAISIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPAISID","Visible")',ctrl:"vCPAISID",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e12071_client=function(){return this.clearMessages(),gx.fn.getCtrlProperty("PAISNOMBREFILTERCONTAINER","Class")=="AdvancedContainerItem"?(gx.fn.setCtrlProperty("PAISNOMBREFILTERCONTAINER","Class","AdvancedContainerItem AdvancedContainerItemExpanded"),gx.fn.setCtrlProperty("vCPAISNOMBRE","Visible",!0)):(gx.fn.setCtrlProperty("PAISNOMBREFILTERCONTAINER","Class","AdvancedContainerItem"),gx.fn.setCtrlProperty("vCPAISNOMBRE","Visible",!1)),this.refreshOutputs([{av:'gx.fn.getCtrlProperty("PAISNOMBREFILTERCONTAINER","Class")',ctrl:"PAISNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPAISNOMBRE","Visible")',ctrl:"vCPAISNOMBRE",prop:"Visible"}]),gx.$.Deferred().resolve()};this.e16072_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e17071_client=function(){return this.executeServerEvent("CANCEL",!0,null,!1,!1)};this.GXValidFnc=[];n=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,35,36,37,38,39,40,41];this.GXLastCtrlId=41;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",34,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0010",[],!1,1,!1,!0,10,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);t=this.Grid1Container;t.addBitmap("&Linkselection","vLINKSELECTION",35,0,"px",17,"px",null,"","","SelectionAttribute","WWActionColumn");t.addSingleLineEdit(1,36,"PAISID","Id","","PaisId","int",0,"px",4,4,"right",null,[],1,"PaisId",!0,0,!1,!1,"Attribute",1,"WWColumn");t.addSingleLineEdit(2,37,"PAISNOMBRE","Nombre","","PaisNombre","char",0,"px",100,80,"left",null,[],2,"PaisNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");t.addBitmap(3,"PAISBANDERA",38,0,"px",17,"px",null,"","Bandera","ImageAttribute","WWColumn OptionalColumn");this.Grid1Container.emptyText="";this.setGrid(t);n[2]={id:2,fld:"",grid:0};n[3]={id:3,fld:"MAIN",grid:0};n[4]={id:4,fld:"",grid:0};n[5]={id:5,fld:"",grid:0};n[6]={id:6,fld:"ADVANCEDCONTAINER",grid:0};n[7]={id:7,fld:"",grid:0};n[8]={id:8,fld:"",grid:0};n[9]={id:9,fld:"PAISIDFILTERCONTAINER",grid:0};n[10]={id:10,fld:"",grid:0};n[11]={id:11,fld:"",grid:0};n[12]={id:12,fld:"LBLPAISIDFILTER",format:1,grid:0,evt:"e11071_client"};n[13]={id:13,fld:"",grid:0};n[14]={id:14,fld:"",grid:0};n[15]={id:15,fld:"",grid:0};n[16]={id:16,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPAISID",gxz:"ZV6cPaisId",gxold:"OV6cPaisId",gxvar:"AV6cPaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV6cPaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.ZV6cPaisId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("vCPAISID",gx.O.AV6cPaisId,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV6cPaisId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("vCPAISID",",")},nac:gx.falseFn};n[17]={id:17,fld:"",grid:0};n[18]={id:18,fld:"",grid:0};n[19]={id:19,fld:"PAISNOMBREFILTERCONTAINER",grid:0};n[20]={id:20,fld:"",grid:0};n[21]={id:21,fld:"",grid:0};n[22]={id:22,fld:"LBLPAISNOMBREFILTER",format:1,grid:0,evt:"e12071_client"};n[23]={id:23,fld:"",grid:0};n[24]={id:24,fld:"",grid:0};n[25]={id:25,fld:"",grid:0};n[26]={id:26,lvl:0,type:"char",len:100,dec:0,sign:!1,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[this.Grid1Container],fld:"vCPAISNOMBRE",gxz:"ZV7cPaisNombre",gxold:"OV7cPaisNombre",gxvar:"AV7cPaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.AV7cPaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.ZV7cPaisNombre=n)},v2c:function(){gx.fn.setControlValue("vCPAISNOMBRE",gx.O.AV7cPaisNombre,0)},c2v:function(){this.val()!==undefined&&(gx.O.AV7cPaisNombre=this.val())},val:function(){return gx.fn.getControlValue("vCPAISNOMBRE")},nac:gx.falseFn};n[27]={id:27,fld:"",grid:0};n[28]={id:28,fld:"GRIDTABLE",grid:0};n[29]={id:29,fld:"",grid:0};n[30]={id:30,fld:"",grid:0};n[31]={id:31,fld:"BTNTOGGLE",grid:0,evt:"e13071_client"};n[32]={id:32,fld:"",grid:0};n[33]={id:33,fld:"",grid:0};n[35]={id:35,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.AV5LinkSelection=n)},v2z:function(n){n!==undefined&&(gx.O.ZV5LinkSelection=n)},v2c:function(n){gx.fn.setGridMultimediaValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34),gx.O.AV5LinkSelection,gx.O.AV12Linkselection_GXI)},c2v:function(n){gx.O.AV12Linkselection_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.AV5LinkSelection=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vLINKSELECTION",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("vLINKSELECTION_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"AV12Linkselection_GXI",nac:gx.falseFn};n[36]={id:36,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISID",gxz:"Z1PaisId",gxold:"O1PaisId",gxvar:"A1PaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A1PaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1PaisId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("PAISID",n||gx.fn.currentGridRowImpl(34),gx.O.A1PaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A1PaisId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("PAISID",n||gx.fn.currentGridRowImpl(34),",")},nac:gx.falseFn};n[37]={id:37,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISNOMBRE",gxz:"Z2PaisNombre",gxold:"O2PaisNombre",gxvar:"A2PaisNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A2PaisNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z2PaisNombre=n)},v2c:function(n){gx.fn.setGridControlValue("PAISNOMBRE",n||gx.fn.currentGridRowImpl(34),gx.O.A2PaisNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A2PaisNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("PAISNOMBRE",n||gx.fn.currentGridRowImpl(34))},nac:gx.falseFn};n[38]={id:38,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:34,gxgrid:this.Grid1Container,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISBANDERA",gxz:"Z3PaisBandera",gxold:"O3PaisBandera",gxvar:"A3PaisBandera",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A3PaisBandera=n)},v2z:function(n){n!==undefined&&(gx.O.Z3PaisBandera=n)},v2c:function(n){gx.fn.setGridMultimediaValue("PAISBANDERA",n||gx.fn.currentGridRowImpl(34),gx.O.A3PaisBandera,gx.O.A40000PaisBandera_GXI)},c2v:function(n){gx.O.A40000PaisBandera_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A3PaisBandera=this.val(n))},val:function(n){return gx.fn.getGridControlValue("PAISBANDERA",n||gx.fn.currentGridRowImpl(34))},val_GXI:function(n){return gx.fn.getGridControlValue("PAISBANDERA_GXI",n||gx.fn.currentGridRowImpl(34))},gxvar_GXI:"A40000PaisBandera_GXI",nac:gx.falseFn};n[39]={id:39,fld:"",grid:0};n[40]={id:40,fld:"",grid:0};n[41]={id:41,fld:"BTN_CANCEL",grid:0,evt:"e17071_client"};this.AV6cPaisId=0;this.ZV6cPaisId=0;this.OV6cPaisId=0;this.AV7cPaisNombre="";this.ZV7cPaisNombre="";this.OV7cPaisNombre="";this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z1PaisId=0;this.O1PaisId=0;this.Z2PaisNombre="";this.O2PaisNombre="";this.Z3PaisBandera="";this.O3PaisBandera="";this.AV6cPaisId=0;this.AV7cPaisNombre="";this.A40000PaisBandera_GXI="";this.AV8pPaisId=0;this.AV5LinkSelection="";this.A1PaisId=0;this.A2PaisNombre="";this.A3PaisBandera="";this.Events={e16072_client:["ENTER",!0],e17071_client:["CANCEL",!0],e13071_client:["'TOGGLE'",!1],e11071_client:["LBLPAISIDFILTER.CLICK",!1],e12071_client:["LBLPAISNOMBREFILTER.CLICK",!1]};this.EvtParms.REFRESH=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cPaisId",fld:"vCPAISID",pic:"ZZZ9"},{av:"AV7cPaisNombre",fld:"vCPAISNOMBRE",pic:""}],[]];this.EvtParms.START=[[],[{ctrl:"FORM",prop:"Caption"}]];this.EvtParms["'TOGGLE'"]=[[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("ADVANCEDCONTAINER","Class")',ctrl:"ADVANCEDCONTAINER",prop:"Class"},{ctrl:"BTNTOGGLE",prop:"Class"}]];this.EvtParms["LBLPAISIDFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PAISIDFILTERCONTAINER","Class")',ctrl:"PAISIDFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PAISIDFILTERCONTAINER","Class")',ctrl:"PAISIDFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPAISID","Visible")',ctrl:"vCPAISID",prop:"Visible"}]];this.EvtParms["LBLPAISNOMBREFILTER.CLICK"]=[[{av:'gx.fn.getCtrlProperty("PAISNOMBREFILTERCONTAINER","Class")',ctrl:"PAISNOMBREFILTERCONTAINER",prop:"Class"}],[{av:'gx.fn.getCtrlProperty("PAISNOMBREFILTERCONTAINER","Class")',ctrl:"PAISNOMBREFILTERCONTAINER",prop:"Class"},{av:'gx.fn.getCtrlProperty("vCPAISNOMBRE","Visible")',ctrl:"vCPAISNOMBRE",prop:"Visible"}]];this.EvtParms.LOAD=[[],[{av:"AV5LinkSelection",fld:"vLINKSELECTION",pic:""}]];this.EvtParms.ENTER=[[{av:"A1PaisId",fld:"PAISID",pic:"ZZZ9",hsh:!0}],[{av:"AV8pPaisId",fld:"vPPAISID",pic:"ZZZ9"}]];this.EvtParms.GRID1_FIRSTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cPaisId",fld:"vCPAISID",pic:"ZZZ9"},{av:"AV7cPaisNombre",fld:"vCPAISNOMBRE",pic:""}],[]];this.EvtParms.GRID1_PREVPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cPaisId",fld:"vCPAISID",pic:"ZZZ9"},{av:"AV7cPaisNombre",fld:"vCPAISNOMBRE",pic:""}],[]];this.EvtParms.GRID1_NEXTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cPaisId",fld:"vCPAISID",pic:"ZZZ9"},{av:"AV7cPaisNombre",fld:"vCPAISNOMBRE",pic:""}],[]];this.EvtParms.GRID1_LASTPAGE=[[{av:"GRID1_nFirstRecordOnPage"},{av:"GRID1_nEOF"},{ctrl:"GRID1",prop:"Rows"},{av:"AV6cPaisId",fld:"vCPAISID",pic:"ZZZ9"},{av:"AV7cPaisNombre",fld:"vCPAISNOMBRE",pic:""}],[]];this.setVCMap("AV8pPaisId","vPPAISID",0,"int",4,0);t.addRefreshingVar(this.GXValidFnc[16]);t.addRefreshingVar(this.GXValidFnc[26]);t.addRefreshingParm(this.GXValidFnc[16]);t.addRefreshingParm(this.GXValidFnc[26]);this.Initialize()});gx.wi(function(){gx.createParentObj(gx0010)})