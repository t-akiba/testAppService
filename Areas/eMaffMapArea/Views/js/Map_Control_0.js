//地図を表示する画面における検索条件の表示

jQuery(function ($) {

	$(function(){
		$.getJSON("../json/searchOption.json", function(val){
			var wak = "";
			for (i = 0; i < val["Category"].length; i++) {

				if(val["Category"][i]["id"] != "checkbox-name"){ //checkbox-name は行程農地一覧側で利用するため
					wak += "<div class='row search_form_row'>\r\n";
					wak += "<div class='col-lg-2'><label for='" + val["Category"][i]["id"] +"'>" + val["Category"][i]["name"] + "</label></div>\r\n";
					wak += "<div class='col-lg-10'>\r\n";

					if(val["Category"][i]["type"] == "select"){
						wak += "<select class='custom-select d-block w-100 search_form_item' id='" + val["Category"][i]["id"] + "' required>\r\n";
						wak += "<option value=''></option>\r\n";
						const formid = val["Category"][i]["id"];
						for (j = 0; j < val[formid].length; j++) {
							wak += "<option value='" + val[formid][j]["value"] + "'>" + val[formid][j]["text"] +"</option>\r\n";
						}
						wak += "</select>\r\n";
					}else if(val["Category"][i]["type"] == "text"){
							wak += "<input type='text' class='form-control search_form_item' id='" + val["Category"][i]["id"] + "'>\r\n";
					}else{
						wak += "<input type='text' class='form-control search_form_item search_form_item_area' id='area1-1' placeholder='' value='' required>\r\n";
						wak += "<label for='area1-2'>～</label>\r\n";
						wak += "<input type='text' class='form-control search_form_item search_form_item_area' id='area1-2' placeholder='' value='' required>\r\n";
					}

					wak += "</div>\r\n";
					wak += "</div>\r\n";
				}
			}

			$(".search_area").append(wak);

		});
	});

});





