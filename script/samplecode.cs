int dialog_select=0;
giSelectDialogAddItem("1.好的跳过"); 
giSelectDialogAddItem("2.不了我要看"); 
giSelectDialogSetDefaultSelect(1);
giShowSelectDialog("要不要跳过?"); 
dialog_select = giSelectDialogGetLastSelect();
if (dialog_select == 1)
{
    giPlayMovie("1A.bik");
    giPlayMovie("Pal4A.bik");
    giOpenMovieFlag(0);
}