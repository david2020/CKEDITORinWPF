this is  the simplest project that use ckeditor 4 in wpf 
ckeditor folder is in BIN/DEBUG 
ckeditor is loaded in Webbrowser control
and then get with this code:
            mshtml.HTMLDocument document = (mshtml.HTMLDocument)browser.Document;
            mshtml.IHTMLElement editor = document.getElementById("cke_1_contents").children[0];
            MessageBox.Show(editor.innerHTML.ToString());
            