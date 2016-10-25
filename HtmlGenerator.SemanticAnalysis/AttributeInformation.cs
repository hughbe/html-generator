using System;
using System.Collections.Generic;
using System.Linq;
using HtmlGenerator.SemanticAnalysis.Analysers.Attributes;

namespace HtmlGenerator.SemanticAnalysis
{
    public class AttributeInformation
    {
        internal AttributeInformation(string tag, AttributeValueType valueType, bool isGlobal = false, IEnumerable<string> validValues = null, SupportedStatus supportedStatus = SupportedStatus.Supported)
        {
            Tag = tag;
            ValueType = valueType;
            IsGlobal = isGlobal;
            ValidValues = validValues ?? Enumerable.Empty<string>();
            SupportedStatus = supportedStatus;
        }

        public string Tag { get; }
        public AttributeValueType ValueType { get; }

        private IAttributeAnalyser _analyser;
        public IAttributeAnalyser Analyser => _analyser ?? (_analyser = GetAnalyser());

        public bool IsGlobal { get; }
        public IEnumerable<string> ValidValues { get; }
        public SupportedStatus SupportedStatus { get; }

        private IAttributeAnalyser GetAnalyser()
        {
            switch (ValueType)
            {
                case AttributeValueType.AsciiCompatibleEncodingSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new EncodingLabelAttributeAnalyser(), allowEmpty: false);
                case AttributeValueType.Bcp47LanguageTag:
                    return new Bcp47LanguageTagAnalyser(allowEmpty: false);
                case AttributeValueType.Bcp47LanguageTagOrEmpty:
                    return new Bcp47LanguageTagAnalyser(allowEmpty: true);
                case AttributeValueType.Boolean:
                    return new BooleanAttributeAnalyser();
                case AttributeValueType.BrowsingContextNameOrKeyword:
                    return new BrowsingContextOrKeywordAnalyser();
                case AttributeValueType.Color:
                    return new ColorAttributeAnalyser();
                case AttributeValueType.ContextSensitive:
                    return new TextAttributeAnalyser(minLength: 0, maxLength: -1);
                case AttributeValueType.CssDeclarations:
                    return new CssDeclarationsAttributeAnalyser();
                case AttributeValueType.DateTime:
                    return new DateTimeAttributeAnalyser();
                case AttributeValueType.DropzoneSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new TextAttributeAnalyser(minLength: 0, maxLength: -1), allowEmpty: true);
                case AttributeValueType.EncodingLabel:
                    return new EncodingLabelAttributeAnalyser();
                case AttributeValueType.Enumerated:
                    return new EnumeratedAnalyser(ValidValues);
                case AttributeValueType.EnumeratedCaseInsensitiveSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new EnumeratedAnalyser(ValidValues), allowEmpty: false);
                case AttributeValueType.FloatingPointCommaDelimitedArray:
                    return new CommaArrayAttributeAnalyser(new FloatingPointAttributeAnalyser(allowNegative: true, allowZero: true));
                case AttributeValueType.FloatingPointNumber:
                    return new FloatingPointAttributeAnalyser(allowNegative: true, allowZero: true);
                case AttributeValueType.HashNameReference:
                    return new HashNameAttributeAnalyser();
                case AttributeValueType.Html:
                    return new HtmlAttributeAnalyser();
                case AttributeValueType.Id:
                    return new IdAttributeAnalyser();
                case AttributeValueType.IdSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new IdAttributeAnalyser(), allowEmpty: true);
                case AttributeValueType.ImageCandidateCommaDelimitedArray:
                    return new CommaArrayAttributeAnalyser(new ImageCandidateAttributeAnalyser());
                case AttributeValueType.Integer:
                    return new IntegerAttributeAnalyser(allowNegative: true, allowZero: true);
                case AttributeValueType.MediaQueryList:
                    return new MediaQueryAttributeAnalyser();
                case AttributeValueType.MimeTypeCommaDelimitedArray:
                    return new CommaArrayAttributeAnalyser(new MimeTypeAttributeAnalyser());
                case AttributeValueType.NonEmptyText:
                    return new TextAttributeAnalyser(minLength: 1, maxLength: -1);
                case AttributeValueType.NonEmptyUrl:
                    return new UrlAttributeAnalyser(allowedKind: UriKind.RelativeOrAbsolute, allowEmpty: false);
                case AttributeValueType.NonEmptyUrlSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new UrlAttributeAnalyser(allowedKind: UriKind.RelativeOrAbsolute, allowEmpty: false), allowEmpty: true);
                case AttributeValueType.NonNegativeInteger:
                    return new IntegerAttributeAnalyser(allowNegative: false, allowZero: true);
                case AttributeValueType.PositiveFloatingPointNumberOrAny:
                    return new StepAttributeAnalyser();
                case AttributeValueType.PositiveInteger:
                    return new IntegerAttributeAnalyser(allowNegative: true, allowZero: true);
                case AttributeValueType.RegularExpression:
                    return new TextAttributeAnalyser(minLength: 1, maxLength: -1);
                case AttributeValueType.SizeCaseInsensitiveSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new TextAttributeAnalyser(minLength: 0, maxLength: -1), allowEmpty: false);
                case AttributeValueType.SpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new TextAttributeAnalyser(minLength: 1, maxLength: -1), allowEmpty: true);
                case AttributeValueType.Text:
                    return new TextAttributeAnalyser(minLength: 0, maxLength: -1);
                case AttributeValueType.UniqueAbsoluteUrlSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new UrlAttributeAnalyser(allowedKind: UriKind.Absolute, allowEmpty: false), allowEmpty: false);
                case AttributeValueType.UniqueOneUnicodeCodePointLengthSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new TextAttributeAnalyser(minLength: 1, maxLength: 1), allowEmpty: false);
                case AttributeValueType.UniqueSpaceSeparatedCaseSensitiveAbsoluteUrlsDefinedPropertyNamesOrTextSpaceDelimitedArray:
                    return new SpaceArrayAttributeAnalyser(new ItemPropAttributeAnalyser(), allowEmpty: false);
                case AttributeValueType.Url:
                    return new UrlAttributeAnalyser(allowedKind: UriKind.RelativeOrAbsolute, allowEmpty: true);
                default:
                    throw new InvalidOperationException("No such analyser");
            }
        }
    }
}
