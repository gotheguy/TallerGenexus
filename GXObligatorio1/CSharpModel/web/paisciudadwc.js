/*!   GeneXus C# 16_0_7-138086 on 2/25/2020 21:45:22.46
*/
gx.evt.autoSkip=!1;gx.define("paisciudadwc",!0,function(n){var t,i;this.ServerClass="paisciudadwc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6PaisId=gx.fn.getIntegerValue("vPAISID",",");this.AV6PaisId=gx.fn.getIntegerValue("vPAISID",",")};this.e13132_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e14132_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,10,11,13,14,15,16,17,18];this.GXLastCtrlId=18;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",12,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"paisciudadwc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(4,13,"CIUDADID","Id","","CiudadId","int",0,"px",4,4,"right",null,[],4,"CiudadId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(5,14,"CIUDADNOMBRE","Nombre","","CiudadNombre","char",0,"px",100,80,"left",null,[],5,"CiudadNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"GRIDCELL",grid:0};t[6]={id:6,fld:"GRIDTABLE",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"",grid:0};t[13]={id:13,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CIUDADID",gxz:"Z4CiudadId",gxold:"O4CiudadId",gxvar:"A4CiudadId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A4CiudadId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z4CiudadId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("CIUDADID",n||gx.fn.currentGridRowImpl(12),gx.O.A4CiudadId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A4CiudadId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("CIUDADID",n||gx.fn.currentGridRowImpl(12),",")},nac:gx.falseFn};t[14]={id:14,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:12,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"CIUDADNOMBRE",gxz:"Z5CiudadNombre",gxold:"O5CiudadNombre",gxvar:"A5CiudadNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A5CiudadNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z5CiudadNombre=n)},v2c:function(n){gx.fn.setGridControlValue("CIUDADNOMBRE",n||gx.fn.currentGridRowImpl(12),gx.O.A5CiudadNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A5CiudadNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("CIUDADNOMBRE",n||gx.fn.currentGridRowImpl(12))},nac:gx.falseFn};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[17]={id:17,fld:"",grid:0};t[18]={id:18,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"PAISID",gxz:"Z1PaisId",gxold:"O1PaisId",gxvar:"A1PaisId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A1PaisId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z1PaisId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("PAISID",gx.O.A1PaisId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A1PaisId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("PAISID",",")},nac:gx.falseFn};this.declareDomainHdlr(18,function(){});this.Z4CiudadId=0;this.O4CiudadId=0;this.Z5CiudadNombre="";this.O5CiudadNombre="";this.A1PaisId=0;this.Z1PaisId=0;this.O1PaisId=0;this.A1PaisId=0;this.AV6PaisId=0;this.A4CiudadId=0;this.A5CiudadNombre="";this.Events={e13132_client:["ENTER",!0],e14132_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6PaisId",fld:"vPAISID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV14Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6PaisId",fld:"vPAISID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:'gx.fn.getCtrlProperty("PAISID","Visible")',ctrl:"PAISID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6PaisId",fld:"vPAISID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6PaisId",fld:"vPAISID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6PaisId",fld:"vPAISID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6PaisId",fld:"vPAISID",pic:"ZZZ9"},{av:"sPrefix"}],[]];this.setVCMap("AV6PaisId","vPAISID",0,"int",4,0);this.setVCMap("AV6PaisId","vPAISID",0,"int",4,0);this.setVCMap("AV6PaisId","vPAISID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6PaisId"});i.addRefreshingParm({rfrVar:"AV6PaisId"});this.Initialize()})