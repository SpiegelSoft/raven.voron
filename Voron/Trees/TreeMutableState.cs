﻿using Voron.Impl.FileHeaders;

namespace Voron.Trees
{
    public unsafe class TreeMutableState
    {
        public long BranchPages;
        public long LeafPages;
        public long OverflowPages;
        public int Depth;
        public long PageCount;
        public long EntriesCount;
	    public TreeFlags Flags;

        public long RootPageNumber;

        public void CopyTo(TreeRootHeader* header)
        {
			header->Flags = Flags;
            header->BranchPages = BranchPages;
            header->Depth = Depth;
            header->LeafPages = LeafPages;
            header->OverflowPages = OverflowPages;
            header->PageCount = PageCount;
            header->EntriesCount = EntriesCount;
            header->RootPageNumber = RootPageNumber;
        }

        public TreeMutableState Clone()
        {
            return new TreeMutableState
                {
                    BranchPages = BranchPages,
                    Depth = Depth,
                    EntriesCount = EntriesCount,
                    LeafPages = LeafPages,
                    OverflowPages = OverflowPages,
                    PageCount = PageCount,
					Flags = Flags,
                    RootPageNumber = RootPageNumber
                };
        }
    }
}