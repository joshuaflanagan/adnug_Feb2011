﻿function showHelp(topic){
	var win = window.open("/main/help?topic=" + topic, "_DynamicHelp", "toolbar=no,menubar=no,width=500px,height=700px");
	if (win != null)
	{
		win.focus();
	}
}