/*!   GeneXus C# 16_0_7-138086 on 2/25/2020 21:45:23.98
*/
gx.evt.autoSkip=!1;gx.define("tipoespectaculoespectaculowc",!0,function(n){var t,i;this.ServerClass="tipoespectaculoespectaculowc";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(n);this.ReadonlyForm=!0;this.anyGridBaseTable=!0;this.hasEnterEvent=!1;this.skipOnEnter=!1;this.autoRefresh=!0;this.fullAjax=!0;this.supportAjaxEvents=!0;this.ajaxSecurityToken=!0;this.SetStandaloneVars=function(){this.AV6TipoEspectaculoId=gx.fn.getIntegerValue("vTIPOESPECTACULOID",",");this.AV6TipoEspectaculoId=gx.fn.getIntegerValue("vTIPOESPECTACULOID",",")};this.Valid_Lugarid=function(){var n=gx.fn.currentGridRowImpl(20);return this.validCliEvt("Valid_Lugarid",20,function(){try{if(gx.fn.currentGridRowImpl(20)===0)return!0;var n=gx.util.balloon.getNew("LUGARID",gx.fn.currentGridRowImpl(20));this.AnyError=0}catch(t){}try{return n==null?!0:n.show()}catch(t){}return!0})};this.e111k2_client=function(){return this.executeServerEvent("'DOINSERT'",!1,null,!1,!1)};this.e141k2_client=function(){return this.executeServerEvent("ENTER",!0,arguments[0],!1,!1)};this.e151k2_client=function(){return this.executeServerEvent("CANCEL",!0,arguments[0],!1,!1)};this.GXValidFnc=[];t=this.GXValidFnc;this.GXCtrlIds=[2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,18,19,21,22,23,24,25,26,27,28,29,30,31,32];this.GXLastCtrlId=32;this.GridContainer=new gx.grid.grid(this,2,"WbpLvl2",20,"Grid","Grid","GridContainer",this.CmpContext,this.IsMasterPage,"tipoespectaculoespectaculowc",[],!1,1,!1,!0,0,!0,!1,!1,"",0,"px",0,"px","New row",!0,!1,!1,null,null,!1,"",!1,[1,1,1,1],!1,0,!0,!1);i=this.GridContainer;i.addSingleLineEdit(34,21,"ESPECTACULOID","Id","","EspectaculoId","int",0,"px",4,4,"right",null,[],34,"EspectaculoId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(35,22,"ESPECTACULONOMBRE","Nombre","","EspectaculoNombre","char",0,"px",100,80,"left",null,[],35,"EspectaculoNombre",!0,0,!1,!1,"DescriptionAttribute",1,"WWColumn");i.addSingleLineEdit(36,23,"ESPECTACULOFECHA","Fecha","","EspectaculoFecha","date",0,"px",10,10,"right",null,[],36,"EspectaculoFecha",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(8,24,"LUGARID","Lugar Id","","LugarId","int",0,"px",4,4,"right",null,[],8,"LugarId",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addSingleLineEdit(9,25,"LUGARNOMBRE","Lugar Nombre","","LugarNombre","char",0,"px",100,80,"left",null,[],9,"LugarNombre",!0,0,!1,!1,"Attribute",1,"WWColumn WWOptionalColumn");i.addBitmap(10,"LUGARFOTO",26,0,"px",17,"px",null,"","Lugar Foto","ImageAttribute","WWColumn WWOptionalColumn");i.addSingleLineEdit("Update",27,"vUPDATE","","","Update","char",0,"px",20,20,"left",null,[],"Update","Update",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");i.addSingleLineEdit("Delete",28,"vDELETE","","","Delete","char",0,"px",20,20,"left",null,[],"Delete","Delete",!0,0,!1,!1,"TextActionAttribute",1,"WWTextActionColumn");this.GridContainer.emptyText="";this.setGrid(i);t[2]={id:2,fld:"",grid:0};t[3]={id:3,fld:"MAINTABLE",grid:0};t[4]={id:4,fld:"",grid:0};t[5]={id:5,fld:"",grid:0};t[6]={id:6,fld:"TABLETOP",grid:0};t[7]={id:7,fld:"",grid:0};t[8]={id:8,fld:"",grid:0};t[9]={id:9,fld:"",grid:0};t[10]={id:10,fld:"",grid:0};t[11]={id:11,fld:"BTNINSERT",grid:0,evt:"e111k2_client"};t[12]={id:12,fld:"",grid:0};t[13]={id:13,fld:"GRIDCELL",grid:0};t[14]={id:14,fld:"GRIDTABLE",grid:0};t[15]={id:15,fld:"",grid:0};t[16]={id:16,fld:"",grid:0};t[18]={id:18,fld:"",grid:0};t[19]={id:19,fld:"",grid:0};t[21]={id:21,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOID",gxz:"Z34EspectaculoId",gxold:"O34EspectaculoId",gxvar:"A34EspectaculoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z34EspectaculoId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOID",n||gx.fn.currentGridRowImpl(20),gx.O.A34EspectaculoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A34EspectaculoId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("ESPECTACULOID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[22]={id:22,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULONOMBRE",gxz:"Z35EspectaculoNombre",gxold:"O35EspectaculoNombre",gxvar:"A35EspectaculoNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A35EspectaculoNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z35EspectaculoNombre=n)},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULONOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A35EspectaculoNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A35EspectaculoNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("ESPECTACULONOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[23]={id:23,lvl:2,type:"date",len:10,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"ESPECTACULOFECHA",gxz:"Z36EspectaculoFecha",gxold:"O36EspectaculoFecha",gxvar:"A36EspectaculoFecha",dp:{f:0,st:!1,wn:!1,mf:!1,pic:"99/99/9999",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A36EspectaculoFecha=gx.fn.toDatetimeValue(n))},v2z:function(n){n!==undefined&&(gx.O.Z36EspectaculoFecha=gx.fn.toDatetimeValue(n))},v2c:function(n){gx.fn.setGridControlValue("ESPECTACULOFECHA",n||gx.fn.currentGridRowImpl(20),gx.O.A36EspectaculoFecha,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A36EspectaculoFecha=gx.fn.toDatetimeValue(this.val(n)))},val:function(n){return gx.fn.getGridDateTimeValue("ESPECTACULOFECHA",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[24]={id:24,lvl:2,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:this.Valid_Lugarid,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LUGARID",gxz:"Z8LugarId",gxold:"O8LugarId",gxvar:"A8LugarId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"number",v2v:function(n){n!==undefined&&(gx.O.A8LugarId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z8LugarId=gx.num.intval(n))},v2c:function(n){gx.fn.setGridControlValue("LUGARID",n||gx.fn.currentGridRowImpl(20),gx.O.A8LugarId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A8LugarId=gx.num.intval(this.val(n)))},val:function(n){return gx.fn.getGridIntegerValue("LUGARID",n||gx.fn.currentGridRowImpl(20),",")},nac:gx.falseFn};t[25]={id:25,lvl:2,type:"char",len:100,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LUGARNOMBRE",gxz:"Z9LugarNombre",gxold:"O9LugarNombre",gxvar:"A9LugarNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.A9LugarNombre=n)},v2z:function(n){n!==undefined&&(gx.O.Z9LugarNombre=n)},v2c:function(n){gx.fn.setGridControlValue("LUGARNOMBRE",n||gx.fn.currentGridRowImpl(20),gx.O.A9LugarNombre,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(n){this.val(n)!==undefined&&(gx.O.A9LugarNombre=this.val(n))},val:function(n){return gx.fn.getGridControlValue("LUGARNOMBRE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[26]={id:26,lvl:2,type:"bits",len:1024,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"LUGARFOTO",gxz:"Z10LugarFoto",gxold:"O10LugarFoto",gxvar:"A10LugarFoto",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",v2v:function(n){n!==undefined&&(gx.O.A10LugarFoto=n)},v2z:function(n){n!==undefined&&(gx.O.Z10LugarFoto=n)},v2c:function(n){gx.fn.setGridMultimediaValue("LUGARFOTO",n||gx.fn.currentGridRowImpl(20),gx.O.A10LugarFoto,gx.O.A40000LugarFoto_GXI)},c2v:function(n){gx.O.A40000LugarFoto_GXI=this.val_GXI();this.val(n)!==undefined&&(gx.O.A10LugarFoto=this.val(n))},val:function(n){return gx.fn.getGridControlValue("LUGARFOTO",n||gx.fn.currentGridRowImpl(20))},val_GXI:function(n){return gx.fn.getGridControlValue("LUGARFOTO_GXI",n||gx.fn.currentGridRowImpl(20))},gxvar_GXI:"A40000LugarFoto_GXI",nac:gx.falseFn};t[27]={id:27,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vUPDATE",gxz:"ZV11Update",gxold:"OV11Update",gxvar:"AV11Update",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV11Update=n)},v2z:function(n){n!==undefined&&(gx.O.ZV11Update=n)},v2c:function(n){gx.fn.setGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20),gx.O.AV11Update,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV11Update=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vUPDATE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[28]={id:28,lvl:2,type:"char",len:20,dec:0,sign:!1,ro:1,isacc:0,grid:20,gxgrid:this.GridContainer,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"vDELETE",gxz:"ZV12Delete",gxold:"OV12Delete",gxvar:"AV12Delete",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",inputType:"text",autoCorrect:"1",v2v:function(n){n!==undefined&&(gx.O.AV12Delete=n)},v2z:function(n){n!==undefined&&(gx.O.ZV12Delete=n)},v2c:function(n){gx.fn.setGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20),gx.O.AV12Delete,0)},c2v:function(n){this.val(n)!==undefined&&(gx.O.AV12Delete=this.val(n))},val:function(n){return gx.fn.getGridControlValue("vDELETE",n||gx.fn.currentGridRowImpl(20))},nac:gx.falseFn};t[29]={id:29,fld:"",grid:0};t[30]={id:30,fld:"",grid:0};t[31]={id:31,fld:"",grid:0};t[32]={id:32,lvl:0,type:"int",len:4,dec:0,sign:!1,pic:"ZZZ9",ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,evt_cvc:null,evt_cvcing:null,rgrid:[],fld:"TIPOESPECTACULOID",gxz:"Z6TipoEspectaculoId",gxold:"O6TipoEspectaculoId",gxvar:"A6TipoEspectaculoId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(n){n!==undefined&&(gx.O.A6TipoEspectaculoId=gx.num.intval(n))},v2z:function(n){n!==undefined&&(gx.O.Z6TipoEspectaculoId=gx.num.intval(n))},v2c:function(){gx.fn.setControlValue("TIPOESPECTACULOID",gx.O.A6TipoEspectaculoId,0);typeof this.dom_hdl=="function"&&this.dom_hdl.call(gx.O)},c2v:function(){this.val()!==undefined&&(gx.O.A6TipoEspectaculoId=gx.num.intval(this.val()))},val:function(){return gx.fn.getIntegerValue("TIPOESPECTACULOID",",")},nac:gx.falseFn};this.declareDomainHdlr(32,function(){});this.Z34EspectaculoId=0;this.O34EspectaculoId=0;this.Z35EspectaculoNombre="";this.O35EspectaculoNombre="";this.Z36EspectaculoFecha=gx.date.nullDate();this.O36EspectaculoFecha=gx.date.nullDate();this.Z8LugarId=0;this.O8LugarId=0;this.Z9LugarNombre="";this.O9LugarNombre="";this.Z10LugarFoto="";this.O10LugarFoto="";this.ZV11Update="";this.OV11Update="";this.ZV12Delete="";this.OV12Delete="";this.A6TipoEspectaculoId=0;this.Z6TipoEspectaculoId=0;this.O6TipoEspectaculoId=0;this.A6TipoEspectaculoId=0;this.A40000LugarFoto_GXI="";this.AV6TipoEspectaculoId=0;this.A34EspectaculoId=0;this.A35EspectaculoNombre="";this.A36EspectaculoFecha=gx.date.nullDate();this.A8LugarId=0;this.A9LugarNombre="";this.A10LugarFoto="";this.AV11Update="";this.AV12Delete="";this.Events={e111k2_client:["'DOINSERT'",!0],e141k2_client:["ENTER",!0],e151k2_client:["CANCEL",!0]};this.EvtParms.REFRESH=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6TipoEspectaculoId",fld:"vTIPOESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.START=[[{av:"AV16Pgmname",fld:"vPGMNAME",pic:""},{av:"AV6TipoEspectaculoId",fld:"vTIPOESPECTACULOID",pic:"ZZZ9"}],[{ctrl:"GRID",prop:"Rows"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:'gx.fn.getCtrlProperty("TIPOESPECTACULOID","Visible")',ctrl:"TIPOESPECTACULOID",prop:"Visible"}]];this.EvtParms["GRID.LOAD"]=[[{av:"A34EspectaculoId",fld:"ESPECTACULOID",pic:"ZZZ9",hsh:!0},{av:"A8LugarId",fld:"LUGARID",pic:"ZZZ9"}],[{av:'gx.fn.getCtrlProperty("vUPDATE","Link")',ctrl:"vUPDATE",prop:"Link"},{av:'gx.fn.getCtrlProperty("vDELETE","Link")',ctrl:"vDELETE",prop:"Link"},{av:'gx.fn.getCtrlProperty("ESPECTACULONOMBRE","Link")',ctrl:"ESPECTACULONOMBRE",prop:"Link"},{av:'gx.fn.getCtrlProperty("LUGARNOMBRE","Link")',ctrl:"LUGARNOMBRE",prop:"Link"}]];this.EvtParms["'DOINSERT'"]=[[{av:"A34EspectaculoId",fld:"ESPECTACULOID",pic:"ZZZ9",hsh:!0}],[]];this.EvtParms.GRID_FIRSTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6TipoEspectaculoId",fld:"vTIPOESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_PREVPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6TipoEspectaculoId",fld:"vTIPOESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_NEXTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6TipoEspectaculoId",fld:"vTIPOESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.GRID_LASTPAGE=[[{av:"GRID_nFirstRecordOnPage"},{av:"GRID_nEOF"},{ctrl:"GRID",prop:"Rows"},{av:"AV6TipoEspectaculoId",fld:"vTIPOESPECTACULOID",pic:"ZZZ9"},{av:"AV11Update",fld:"vUPDATE",pic:""},{av:"AV12Delete",fld:"vDELETE",pic:""},{av:"sPrefix"}],[]];this.EvtParms.VALID_LUGARID=[[],[]];this.setVCMap("AV6TipoEspectaculoId","vTIPOESPECTACULOID",0,"int",4,0);this.setVCMap("AV6TipoEspectaculoId","vTIPOESPECTACULOID",0,"int",4,0);this.setVCMap("AV6TipoEspectaculoId","vTIPOESPECTACULOID",0,"int",4,0);i.addRefreshingVar({rfrVar:"AV6TipoEspectaculoId"});i.addRefreshingVar({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingVar({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});i.addRefreshingParm({rfrVar:"AV6TipoEspectaculoId"});i.addRefreshingParm({rfrVar:"AV11Update",rfrProp:"Value",gxAttId:"Update"});i.addRefreshingParm({rfrVar:"AV12Delete",rfrProp:"Value",gxAttId:"Delete"});this.Initialize()})