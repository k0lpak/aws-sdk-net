/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Represents the data structure of a method's request or response payload.
    /// 
    ///  <div class="remarks"> 
    /// <para>
    /// A request model defines the data structure of the client-supplied request payload.
    /// A response model defines the data structure of the response payload returned by the
    /// back end. Although not required, models are useful for mapping payloads between the
    /// front end and back end.
    /// </para>
    ///  
    /// <para>
    /// A model is used for generating an API's SDK, validating the input request body, and
    /// creating a skeletal mapping template.
    /// </para>
    ///  </div> <div class="seeAlso"> <a>Method</a>, <a>MethodResponse</a>, <a href="[[AwsDocsUrlPrefix]]/apigateway/latest/developerguide/models-mappings.html">Models
    /// and Mappings</a> </div>
    /// </summary>
    public partial class GetModelResponse : AmazonWebServiceResponse
    {
        private string _contentType;
        private string _description;
        private string _id;
        private string _name;
        private string _schema;

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// The content-type for the model.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the model.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The identifier for the model resource.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the model. Must be an alphanumeric string.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema for the model. For <code>application/json</code> models, this should be
        /// <a href="[[JsonSchemaUrl]]" target="_blank">JSON schema draft 4</a> model. Do not
        /// include "\*/" characters in the description of any properties because such "\*/" characters
        /// may be interpreted as the closing marker for comments in some languages, such as Java
        /// or JavaScript, causing the installation of your API's SDK generated by API Gateway
        /// to fail.
        /// </para>
        /// </summary>
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

    }
}