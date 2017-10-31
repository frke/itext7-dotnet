/*

This file is part of the iText (R) project.
Copyright (c) 1998-2017 iText Group NV
Authors: Bruno Lowagie, Paulo Soares, et al.

This program is free software; you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License version 3
as published by the Free Software Foundation with the addition of the
following permission added to Section 15 as permitted in Section 7(a):
FOR ANY PART OF THE COVERED WORK IN WHICH THE COPYRIGHT IS OWNED BY
ITEXT GROUP. ITEXT GROUP DISCLAIMS THE WARRANTY OF NON INFRINGEMENT
OF THIRD PARTY RIGHTS

This program is distributed in the hope that it will be useful, but
WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY
or FITNESS FOR A PARTICULAR PURPOSE.
See the GNU Affero General Public License for more details.
You should have received a copy of the GNU Affero General Public License
along with this program; if not, see http://www.gnu.org/licenses or write to
the Free Software Foundation, Inc., 51 Franklin Street, Fifth Floor,
Boston, MA, 02110-1301 USA, or download the license from the following URL:
http://itextpdf.com/terms-of-use/

The interactive user interfaces in modified source and object code versions
of this program must display Appropriate Legal Notices, as required under
Section 5 of the GNU Affero General Public License.

In accordance with Section 7(b) of the GNU Affero General Public License,
a covered work must retain the producer line in every PDF that is created
or manipulated using iText.

You can be released from the requirements of the license by purchasing
a commercial license. Buying such a license is mandatory as soon as you
develop commercial activities involving the iText software without
disclosing the source code of your own applications.
These activities include: offering paid services to customers as an ASP,
serving PDFs on the fly in a web application, shipping iText with a closed
source product.

For more information, please contact iText Software Corp. at this
address: sales@itextpdf.com
*/
using System;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;

namespace iText.Kernel.Pdf.Annot {
    public class PdfStampAnnotation : PdfMarkupAnnotation {
        public PdfStampAnnotation(Rectangle rect)
            : base(rect) {
        }

        /// <param name="pdfObject">object representing this annotation</param>
        [System.ObsoleteAttribute(@"Use PdfAnnotation.MakeAnnotation(iText.Kernel.Pdf.PdfObject) instead. Will be made protected in 7.1"
            )]
        public PdfStampAnnotation(PdfDictionary pdfObject)
            : base(pdfObject) {
        }

        public override PdfName GetSubtype() {
            return PdfName.Stamp;
        }

        public virtual iText.Kernel.Pdf.Annot.PdfStampAnnotation SetStampName(PdfName name) {
            return (iText.Kernel.Pdf.Annot.PdfStampAnnotation)Put(PdfName.Name, name);
        }

        public virtual PdfName GetStampName() {
            return GetPdfObject().GetAsName(PdfName.Name);
        }

        /// <summary>The name of an icon that is used in displaying the annotation.</summary>
        /// <remarks>
        /// The name of an icon that is used in displaying the annotation.
        /// Possible values are described in
        /// <see cref="SetIconName(iText.Kernel.Pdf.PdfName)"/>
        /// .
        /// </remarks>
        /// <returns>
        /// a
        /// <see cref="iText.Kernel.Pdf.PdfName"/>
        /// that specifies the icon for displaying annotation, or null if icon name is not specified.
        /// </returns>
        public override PdfName GetIconName() {
            return GetPdfObject().GetAsName(PdfName.Name);
        }

        /// <summary>The name of an icon that is used in displaying the annotation.</summary>
        /// <param name="name">
        /// a
        /// <see cref="iText.Kernel.Pdf.PdfName"/>
        /// that specifies the icon for displaying annotation. Possible values are:
        /// <ul>
        /// <li>Approved</li>
        /// <li>Experimental</li>
        /// <li>NotApproved</li>
        /// <li>AsIs</li>
        /// <li>Expired</li>
        /// <li>NotForPublicRelease</li>
        /// <li>Confidential</li>
        /// <li>Final</li>
        /// <li>Sold</li>
        /// <li>Departmental</li>
        /// <li>ForComment</li>
        /// <li>TopSecret</li>
        /// <li>Draft</li>
        /// <li>ForPublicRelease.</li>
        /// </ul>
        /// </param>
        /// <returns>
        /// this
        /// <see cref="PdfStampAnnotation"/>
        /// instance.
        /// </returns>
        public override PdfMarkupAnnotation SetIconName(PdfName name) {
            return (iText.Kernel.Pdf.Annot.PdfStampAnnotation)Put(PdfName.Name, name);
        }
    }
}
