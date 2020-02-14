const pageLoader = (strType, parent = "body") => {
    let something;
    let theName = strType.toLowerCase();
    something = theName === 'show' ? $(parent).LoadingOverlay("show", { background: "rgba(0,0,0,0.6)" }) :
        theName == 'hide' ? $(parent).LoadingOverlay("hide", true) : console.log('Contact CoderBot if Loader does not work!');
    return something;
};