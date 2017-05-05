namespace MFaaP.MFWSClient
{
	/// <summary>
	/// Represents a search condition that restricts by a multi-select lookup property value.
	/// </summary>
	public class MultiSelectLookupPropertyValueSearchCondition
		: PropertyValueSearchConditionBase<string>
	{
		/// <summary>
		/// Creates a <see cref="MultiSelectLookupPropertyValueSearchCondition"/>, searching for the lookup value supplied.
		/// </summary>
		/// <param name="propertyDefId">The Id of the property def to search by.</param>
		/// <param name="lookupIds">The Ids of the lookup value to search by.</param>
		/// <param name="searchConditionOperator">The operator to use (defaults to Equals if not provided).</param>
		/// <param name="invertOperator">Whether to invert the search operator (defaults to false if not provided).</param>
		/// <remarks>If multiple lookup Ids are present, then objects matching any one of the Ids will be returned (e.g. "class is one of 1, 2, 3, or 4").</remarks>
		public MultiSelectLookupPropertyValueSearchCondition(
			int propertyDefId,
			SearchConditionOperators searchConditionOperator = SearchConditionOperators.Equals,
			bool invertOperator = false,
			params int[] lookupIds)
			: base(propertyDefId, string.Join(",", lookupIds), searchConditionOperator, invertOperator)
		{
		}

		/// <summary>
		/// Creates a <see cref="MultiSelectLookupPropertyValueSearchCondition"/>, searching for the lookup value supplied.
		/// Note that this constructor allows you to provide an external Id (or display Id).  This is used ONLY when objects are
		/// loaded from an external system: http://www.m-files.com/user-guide/latest/eng/#Connection_to_external_database.html.
		/// </summary>
		/// <param name="propertyDefId">The Id of the property def to search by.</param>
		/// <param name="externalLookupIds">The Ids of the lookup value IN THE EXTERNAL SYSTEM.</param>
		/// <param name="searchConditionOperator">The operator to use (defaults to Equals if not provided).</param>
		/// <param name="invertOperator">Whether to invert the search operator (defaults to false if not provided).</param>
		/// <remarks>If multiple lookup Ids are present, then objects matching any one of the Ids will be returned (e.g. "class is one of 1, 2, 3, or 4").</remarks>
		public MultiSelectLookupPropertyValueSearchCondition(
			int propertyDefId,
			SearchConditionOperators searchConditionOperator = SearchConditionOperators.Equals,
			bool invertOperator = false,
			params string[] externalLookupIds)
			: base(propertyDefId, "e" + string.Join(",e", externalLookupIds), searchConditionOperator, invertOperator)
		{
		}
	}
}