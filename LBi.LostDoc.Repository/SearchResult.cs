/*
 * Copyright 2012-2013 LBi Netherlands B.V.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License. 
 */

using System;

namespace LBi.LostDoc.Repository
{
    public class SearchResult
    {
        public string Name { get; set; }

        public string Title { get; set; }

        public Uri Url { get; set; }

        public AssetIdentifier AssetId { get; set; }

        public string Blurb { get; set; }

        public string Type { get; set; }

        public Tuple<string, string, string[]>[] RawDocument { get; set; }

        public string[] Flags { get; set; }

        public PathFragment[] Path { get; set; }
    }
}
