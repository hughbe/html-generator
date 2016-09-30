namespace HtmlGenerator 
{
    public static class Attribute 
    {
		public static HtmlAcceptAttribute Accept(string value) => new HtmlAcceptAttribute(value);
		public static HtmlAcceptCharsetAttribute AcceptCharset(string value) => new HtmlAcceptCharsetAttribute(value);
		public static HtmlAccessKeyAttribute AccessKey(string value) => new HtmlAccessKeyAttribute(value);
		public static HtmlActionAttribute Action(string value) => new HtmlActionAttribute(value);
		public static HtmlAllowFullScreenAttribute AllowFullScreen => new HtmlAllowFullScreenAttribute();
		public static HtmlAltAttribute Alt(string value) => new HtmlAltAttribute(value);
		public static HtmlAsyncAttribute Async(string value) => new HtmlAsyncAttribute(value);
		public static HtmlAutoCompleteAttribute AutoComplete(string value) => new HtmlAutoCompleteAttribute(value);
		public static HtmlAutoFocusAttribute AutoFocus => new HtmlAutoFocusAttribute();
		public static HtmlAutoPlayAttribute AutoPlay(string value) => new HtmlAutoPlayAttribute(value);
		public static HtmlAutoSaveAttribute AutoSave(string value) => new HtmlAutoSaveAttribute(value);

		public static HtmlCharsetAttribute Charset(string value) => new HtmlCharsetAttribute(value);
		public static HtmlCheckedAttribute Checked => new HtmlCheckedAttribute();
		public static HtmlCiteAttribute Cite(string value) => new HtmlCiteAttribute(value);
		public static HtmlClassAttribute Class(string value) => new HtmlClassAttribute(value);
		public static HtmlColorAttribute Color(string value) => new HtmlColorAttribute(value);
		public static HtmlColsAttribute Cols(string value) => new HtmlColsAttribute(value);
		public static HtmlColSpanAttribute ColSpan(string value) => new HtmlColSpanAttribute(value);
		public static HtmlCommandAttribute Command(string value) => new HtmlCommandAttribute(value);
		public static HtmlCompactAttribute Compact(string value) => new HtmlCompactAttribute(value);
		public static HtmlContentAttribute Content(string value) => new HtmlContentAttribute(value);
		public static HtmlContentEditableAttribute ContentEditable(string value) => new HtmlContentEditableAttribute(value);
		public static HtmlContextMenuAttribute ContextMenu(string value) => new HtmlContextMenuAttribute(value);
		public static HtmlControlsAttribute Controls => new HtmlControlsAttribute();
		public static HtmlCoordsAttribute Coords(string value) => new HtmlCoordsAttribute(value);
		public static HtmlCrossOriginAttribute CrossOrigin(string value) => new HtmlCrossOriginAttribute(value);

		public static HtmlDataAttribute Data(string value) => new HtmlDataAttribute(value);
		public static HtmlDateTimeAttribute DateTime(string value) => new HtmlDateTimeAttribute(value);
		public static HtmlDefaultAttribute Default => new HtmlDefaultAttribute();
		public static HtmlDefaultStyleAttribute DefaultStyle(string value) => new HtmlDefaultStyleAttribute(value);
		public static HtmlDeferAttribute Defer(string value) => new HtmlDeferAttribute(value);
		public static HtmlDirAttribute Dir(string value) => new HtmlDirAttribute(value);
		public static HtmlDisabledAttribute Disabled => new HtmlDisabledAttribute();
		public static HtmlDownloadAttribute Download(string value) => new HtmlDownloadAttribute(value);
		public static HtmlDraggableAttribute Draggable(string value) => new HtmlDraggableAttribute(value);
		public static HtmlDropZoneAttribute DropZone(string value) => new HtmlDropZoneAttribute(value);

		public static HtmlEncTypeAttribute EncType(string value) => new HtmlEncTypeAttribute(value);

		public static HtmlForAttribute For(string value) => new HtmlForAttribute(value);
		public static HtmlFormAttribute Form(string value) => new HtmlFormAttribute(value);
		public static HtmlFormActionAttribute FormAction(string value) => new HtmlFormActionAttribute(value);
		public static HtmlFormEncTypeAttribute FormEncType(string value) => new HtmlFormEncTypeAttribute(value);
		public static HtmlFormMethodAttribute FormMethod(string value) => new HtmlFormMethodAttribute(value);
		public static HtmlFormNoValidateAttribute FormNoValidate => new HtmlFormNoValidateAttribute();
		public static HtmlFormTargetAttribute FormTarget(string value) => new HtmlFormTargetAttribute(value);

		public static HtmlHeadersAttribute Headers(string value) => new HtmlHeadersAttribute(value);
		public static HtmlHeightAttribute Height(string value) => new HtmlHeightAttribute(value);
		public static HtmlHiddenAttribute Hidden(string value) => new HtmlHiddenAttribute(value);
		public static HtmlHighAttribute High(string value) => new HtmlHighAttribute(value);
		public static HtmlHrefAttribute Href(string value) => new HtmlHrefAttribute(value);
		public static HtmlHrefLangAttribute HrefLang(string value) => new HtmlHrefLangAttribute(value);
		public static HtmlHttpEquivAttribute HttpEquiv(string value) => new HtmlHttpEquivAttribute(value);

		public static HtmlIconAttribute Icon(string value) => new HtmlIconAttribute(value);
		public static HtmlIdAttribute Id(string value) => new HtmlIdAttribute(value);
		public static HtmlInputModeAttribute InputMode(string value) => new HtmlInputModeAttribute(value);
		public static HtmlIntegrityAttribute Integrity(string value) => new HtmlIntegrityAttribute(value);
		public static HtmlIsMapAttribute IsMap(string value) => new HtmlIsMapAttribute(value);

		public static HtmlKindAttribute Kind(string value) => new HtmlKindAttribute(value);

		public static HtmlLabelAttribute Label(string value) => new HtmlLabelAttribute(value);
		public static HtmlLangAttribute Lang(string value) => new HtmlLangAttribute(value);
		public static HtmlListAttribute List(string value) => new HtmlListAttribute(value);
		public static HtmlLongDescAttribute LongDesc(string value) => new HtmlLongDescAttribute(value);
		public static HtmlLoopAttribute Loop(string value) => new HtmlLoopAttribute(value);
		public static HtmlLowAttribute Low(string value) => new HtmlLowAttribute(value);

		public static HtmlMaxAttribute Max(string value) => new HtmlMaxAttribute(value);
		public static HtmlMaxLengthAttribute MaxLength(string value) => new HtmlMaxLengthAttribute(value);
		public static HtmlMediaAttribute Media(string value) => new HtmlMediaAttribute(value);
		public static HtmlMethodAttribute Method(string value) => new HtmlMethodAttribute(value);
		public static HtmlMinAttribute Min(string value) => new HtmlMinAttribute(value);
		public static HtmlMinLengthAttribute MinLength(string value) => new HtmlMinLengthAttribute(value);
		public static HtmlMultipleAttribute Multiple => new HtmlMultipleAttribute();
		public static HtmlMutedAttribute Muted(string value) => new HtmlMutedAttribute(value);

		public static HtmlNameAttribute Name(string value) => new HtmlNameAttribute(value);
		public static HtmlNoValidateAttribute NoValidate => new HtmlNoValidateAttribute();
		public static HtmlNoWrapAttribute NoWrap(string value) => new HtmlNoWrapAttribute(value);

		public static HtmlOptimumAttribute Optimum(string value) => new HtmlOptimumAttribute(value);
		public static HtmlOpenAttribute Open(string value) => new HtmlOpenAttribute(value);

		public static HtmlPatternAttribute Pattern(string value) => new HtmlPatternAttribute(value);
		public static HtmlPingAttribute Ping(string value) => new HtmlPingAttribute(value);
		public static HtmlPlaceholderAttribute Placeholder(string value) => new HtmlPlaceholderAttribute(value);
		public static HtmlPreloadAttribute Preload(string value) => new HtmlPreloadAttribute(value);
		public static HtmlPosterAttribute Poster(string value) => new HtmlPosterAttribute(value);

		public static HtmlRadioGroupAttribute RadioGroup(string value) => new HtmlRadioGroupAttribute(value);
		public static HtmlReadonlyAttribute Readonly => new HtmlReadonlyAttribute();
		public static HtmlRefreshAttribute Refresh(string value) => new HtmlRefreshAttribute(value);
		public static HtmlRelAttribute Rel(string value) => new HtmlRelAttribute(value);
		public static HtmlRequiredAttribute Required => new HtmlRequiredAttribute();
		public static HtmlReversedAttribute Reversed(string value) => new HtmlReversedAttribute(value);
		public static HtmlRowsAttribute Rows(string value) => new HtmlRowsAttribute(value);
		public static HtmlRowSpanAttribute RowSpan(string value) => new HtmlRowSpanAttribute(value);

		public static HtmlSandboxAttribute Sandbox => new HtmlSandboxAttribute();
		public static HtmlSeamlessAttribute Seamless => new HtmlSeamlessAttribute();
		public static HtmlSelectedAttribute Selected => new HtmlSelectedAttribute();
		public static HtmlSelectionDirectionAttribute SelectionDirection(string value) => new HtmlSelectionDirectionAttribute(value);
		public static HtmlScopeAttribute Scope(string value) => new HtmlScopeAttribute(value);
		public static HtmlScopedAttribute Scoped => new HtmlScopedAttribute();
		public static HtmlShapeAttribute Shape(string value) => new HtmlShapeAttribute(value);
		public static HtmlSizeAttribute Size(string value) => new HtmlSizeAttribute(value);
		public static HtmlSizesAttribute Sizes(string value) => new HtmlSizesAttribute(value);
		public static HtmlSpanAttribute Span(string value) => new HtmlSpanAttribute(value);
		public static HtmlSpellCheckAttribute SpellCheck(string value) => new HtmlSpellCheckAttribute(value);
		public static HtmlSrcAttribute Src(string value) => new HtmlSrcAttribute(value);
		public static HtmlSrcDocAttribute SrcDoc(string value) => new HtmlSrcDocAttribute(value);
		public static HtmlSrcLangAttribute SrcLang(string value) => new HtmlSrcLangAttribute(value);
		public static HtmlSrcSetAttribute SrcSet(string value) => new HtmlSrcSetAttribute(value);
		public static HtmlStartAttribute Start(string value) => new HtmlStartAttribute(value);
		public static HtmlStepAttribute Step(string value) => new HtmlStepAttribute(value);
		public static HtmlStyleAttribute Style(string value) => new HtmlStyleAttribute(value);

		public static HtmlTabIndexAttribute TabIndex(string value) => new HtmlTabIndexAttribute(value);
		public static HtmlTargetAttribute Target(string value) => new HtmlTargetAttribute(value);
		public static HtmlTextAttribute Text(string value) => new HtmlTextAttribute(value);
		public static HtmlTitleAttribute Title(string value) => new HtmlTitleAttribute(value);
		public static HtmlTranslateAttribute Translate(string value) => new HtmlTranslateAttribute(value);
		public static HtmlTypeAttribute Type(string value) => new HtmlTypeAttribute(value);
		public static HtmlTypeMustMatchAttribute TypeMustMatch => new HtmlTypeMustMatchAttribute();

		public static HtmlUseMapAttribute UseMap(string value) => new HtmlUseMapAttribute(value);

		public static HtmlValueAttribute Value(string value) => new HtmlValueAttribute(value);
		public static HtmlVolumeAttribute Volume(string value) => new HtmlVolumeAttribute(value);

		public static HtmlWidthAttribute Width(string value) => new HtmlWidthAttribute(value);
		public static HtmlWrapAttribute Wrap(string value) => new HtmlWrapAttribute(value);

		public static HtmlXmlsAttribute Xmls(string value) => new HtmlXmlsAttribute(value);

		public static HtmlAlignAttribute Align(string value) => new HtmlAlignAttribute(value);

		public static HtmlBgColorAttribute BgColor(string value) => new HtmlBgColorAttribute(value);
		public static HtmlBorderAttribute Border(string value) => new HtmlBorderAttribute(value);

		public static HtmlCellPaddingAttribute CellPadding(string value) => new HtmlCellPaddingAttribute(value);
		public static HtmlCellSpacingAttribute CellSpacing(string value) => new HtmlCellSpacingAttribute(value);

    }
}